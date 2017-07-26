using System;
using System.Collections;
using Dota2Api.Extensions;
using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses {
    /// <summary>
    /// Player slot info (position in scoretab and side).
    /// </summary>
    public class PlayerSlot {
        /// <summary>
        /// Team (usually false if Radiant and true if Dire, but here - 0 for Radiant and 1 for Dire).
        /// </summary>
        public Team side { get; private set; }
        /// <summary>
        /// The position of a player within their team (0-4).
        /// </summary>
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

            this.side = bytePlayerSlot.GetBit(7) == true ? Team.Dire : Team.Radiant;

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
