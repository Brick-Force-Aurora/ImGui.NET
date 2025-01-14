using System.Runtime.InteropServices;
using System.Text;
using System;

namespace ImGuiNET
{
    public unsafe struct NullTerminatedString
    {
        public readonly byte* Data;

        public NullTerminatedString(byte* data)
        {
            Data = data;
        }

        public override string ToString()
        {
            int length = 0;
            byte* ptr = Data;
            while (*ptr != 0)
            {
                length += 1;
                ptr += 1;
            }

            return Marshal.PtrToStringAnsi((IntPtr)Data);
            //return Encoding.ASCII.GetString(Data, 0, length);
        }

        public static implicit operator string(NullTerminatedString nts) => nts.ToString();
    }
}
