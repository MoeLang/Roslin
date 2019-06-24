using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslin.Msg;
using System.IO;
using System.Linq;

namespace Roslin.MsgGen
{
    public class MsgGenerator
    {
        public MsgGenerator(string rootPath) => MsgParser.LoadPath(rootPath);
        public void GenerateCodeToPath(string savePath)
        {
            foreach (var item in MsgParser.Msgs)
            {
                string codeFile = Path.Combine(savePath, item.Key + ".cs");
                string directory = Path.GetDirectoryName(codeFile);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(codeFile, GenerateCode(item.Value));
            }
        }
        private string GenerateCode(MsgParser msgParser) 
            => GenNameSpace(msgParser)
            .AddMembers(GenClass(msgParser)
            .AddMembers(GenConsts(msgParser))
            .AddMembers(GenFields(msgParser))
            .AddMembers(GenNoParamConstructor(msgParser))
            .AddMembers(GenParamConstructor(msgParser))
            .AddMembers(GenSerilizeMethod(msgParser))
            .AddMembers(GenDeserilizeMethod(msgParser)))
            .NormalizeWhitespace().ToFullString();
        private NamespaceDeclarationSyntax GenNameSpace(MsgParser msgParser)
            => SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName($"{typeof(RosMsg).Namespace}.{msgParser.Package}"));
        private ClassDeclarationSyntax GenClass(MsgParser msgParser)
            => SyntaxFactory.ClassDeclaration(msgParser.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword))
            .AddAttributeLists(SyntaxFactory.AttributeList(new SeparatedSyntaxList<AttributeSyntax>().Add(SyntaxFactory.Attribute(SyntaxFactory.ParseName(typeof(MsgInfo).Name), 
                SyntaxFactory.ParseAttributeArgumentList($"(\"{ msgParser.RosType}\",\"{ msgParser.MD5Sum}\",@\"{ msgParser.Content.Replace("\"", "\"\"")}\")")))))
            .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(typeof(RosMsg).Name)));
        private MemberDeclarationSyntax[] GenConsts(MsgParser msgParser)
            => msgParser.Constants.Select(_ => SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(_.Type), _.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.ParseExpression(_.Value)))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))).ToArray();
        private MemberDeclarationSyntax[] GenFields(MsgParser msgParser)
            => msgParser.Fields.Select(_ => SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(_.LocalType), _.LocalName)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)))).ToArray();
        private ConstructorDeclarationSyntax GenNoParamConstructor(MsgParser msgParser)
            => SyntaxFactory.ConstructorDeclaration(msgParser.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithInitializer(SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer))
            .WithBody(SyntaxFactory.Block());
        private ConstructorDeclarationSyntax GenParamConstructor(MsgParser msgParser)
            => SyntaxFactory.ConstructorDeclaration(msgParser.Name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("binaryReader"))
            .WithType(SyntaxFactory.ParseTypeName(typeof(BinaryReader).FullName)))
            .WithInitializer(SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer)
            .AddArgumentListArguments(SyntaxFactory.Argument(SyntaxFactory.IdentifierName("binaryReader"))))
            .WithBody(SyntaxFactory.Block());
        private MethodDeclarationSyntax GenSerilizeMethod(MsgParser msgParser)
            => SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("void"), "Serilize")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.OverrideKeyword))
            .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("binaryWriter"))
            .WithType(SyntaxFactory.ParseTypeName(typeof(BinaryWriter).FullName)))
            .WithBody(SyntaxFactory.Block(msgParser.Fields.Select(_ => SyntaxFactory.ParseStatement(_.Serilize))));
        private MethodDeclarationSyntax GenDeserilizeMethod(MsgParser msgParser)
            => SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("void"), "Deserilize")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.OverrideKeyword))
            .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("binaryReader"))
            .WithType(SyntaxFactory.ParseTypeName(typeof(BinaryReader).FullName)))
            .WithBody(SyntaxFactory.Block(msgParser.Fields.Select(_ => SyntaxFactory.ParseStatement(_.Deserilize))));
    }
}