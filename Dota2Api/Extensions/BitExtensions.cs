﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2API.Extensions {
    public static class BitExtensions {
        public static bool GetBit(this byte b, int bitNumber) {
            return (b & (1 << bitNumber)) != 0;
        }

        public static bool GetBit(this UInt16 b, int bitNumber) {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}
