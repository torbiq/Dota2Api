using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Api.Extensions {
    public static class BitExtensions {
        //public static byte GetBits(byte value) {
        //    return (byte)((value & 0x70) >> 4);
        //}

        //public static int GetIntFromBits(this byte b, int[] indexes) {
        //    int returnedInt = 0;
        //    Bit
        //    return returnedInt;
        //}

        public static bool GetBit(this byte b, int bitNumber) {
            return (b & (1 << bitNumber)) != 0;
        }

        public static bool GetBit(this UInt16 b, int bitNumber) {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}
