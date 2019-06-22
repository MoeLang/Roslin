namespace Roslin.Msg
{
    namespace std_msgs
    {
        public partial class String
        {
            public static implicit operator String(string data) => new String() { data = data };
            public static implicit operator string(String data) => data.data;
            public override string ToString() => data;
        }
        public partial class Bool
        {
            public static implicit operator Bool(bool data) => new Bool() { data = data };
            public static implicit operator bool(Bool data) => data.data;
        }
        public partial class UInt8
        {
            public static implicit operator UInt8(byte data) => new UInt8() { data = data };
            public static implicit operator byte(UInt8 data) => data.data;
        }
        public partial class UInt32
        {
            public static implicit operator UInt32(uint data) => new UInt32() { data = data };
            public static implicit operator uint(UInt32 data) => data.data;
        }
        public partial class Float64
        {
            public static implicit operator Float64(double data) => new Float64() { data = data };
            public static implicit operator double(Float64 data) => data.data;
        }
    }
}
