using System;
using System.Collections;
using Dota2Api.Extensions;
using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses {
    public class PlayerSlot {
        public Side side { get; private set; }
        public PlayerTabPosition position { get; private set; }
        public PlayerSlot(string parsedSByte) {
            // A player's slot is returned via an 8-bit unsigned integer.
            // The first bit represent the player's team, false if Radia-
            // nt and true if dire. The final three bits represent the
            // player's position in that team, from 0-4.
            // ┌─────────────── Team(false if Radiant, true if Dire).
            // │ ┌─┬─┬─┬─────── Not used.
            // │ │ │ │ │ ┌─┬─┬─ The position of a player within their team(0 - 4).
            // │ │ │ │ │ │ │ │
            // 0 0 0 0 0 0 0 0

            byte bytePlayerSlot = Byte.Parse(parsedSByte);

            this.side = bytePlayerSlot.GetBit(7) == true ? Side.Dire : Side.Radiant;

            BitArray bitArray = new BitArray(3);
            bitArray.Set(0, bytePlayerSlot.GetBit(0));
            bitArray.Set(1, bytePlayerSlot.GetBit(1));
            bitArray.Set(2, bytePlayerSlot.GetBit(2));

            int[] intArray = new int[1];
            ((ICollection)bitArray).CopyTo(intArray, 0);
            this.position = (PlayerTabPosition)intArray[0];
        }
    }
}
