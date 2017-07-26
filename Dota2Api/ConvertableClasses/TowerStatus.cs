using Dota2Api.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using Dota2Api.Extensions;

namespace Dota2Api.ConvertableClasses {
    /// <summary>
    /// Tower status list (destroyed or not).
    /// </summary>
    public class TowerStatus {
        /// <summary>
        /// List of tower statuses.
        /// </summary>
        public Dictionary<Tower, bool> list { get; private set; }
        
        public TowerStatus(string parsedUint16) {
            // A particular teams tower status is given as a 16 - bit unsigned integer.
            // The rightmost 11 bits represent individual towers belonging to that team;
            // see below for a visual representation.
            // ┌─┬─┬─┬─┬─────────────────────── Not used.
            // │ │ │ │ │ ┌───────────────────── Ancient Bottom
            // │ │ │ │ │ │ ┌─────────────────── Ancient Top
            // │ │ │ │ │ │ │ ┌───────────────── Bottom Tier 3
            // │ │ │ │ │ │ │ │ ┌─────────────── Bottom Tier 2
            // │ │ │ │ │ │ │ │ │ ┌───────────── Bottom Tier 1
            // │ │ │ │ │ │ │ │ │ │ ┌─────────── Middle Tier 3
            // │ │ │ │ │ │ │ │ │ │ │ ┌───────── Middle Tier 2
            // │ │ │ │ │ │ │ │ │ │ │ │ ┌─────── Middle Tier 1
            // │ │ │ │ │ │ │ │ │ │ │ │ │ ┌───── Top Tier 3
            // │ │ │ │ │ │ │ │ │ │ │ │ │ │ ┌─── Top Tier 2
            // │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ ┌─ Top Tier 1
            // │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ │
            // 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0

            ushort receivedTowers = ushort.Parse(parsedUint16);

            this.list = new Dictionary<Tower, bool>();
            list.Add(Tower.Ancient_Bottom, receivedTowers.GetBit(10));
            list.Add(Tower.Ancient_Top, receivedTowers.GetBit(9));
            list.Add(Tower.Bottom_Tier_3, receivedTowers.GetBit(8));
            list.Add(Tower.Bottom_Tier_2, receivedTowers.GetBit(7));
            list.Add(Tower.Bottom_Tier_1, receivedTowers.GetBit(6));
            list.Add(Tower.Middle_Tier_3, receivedTowers.GetBit(5));
            list.Add(Tower.Middle_Tier_2, receivedTowers.GetBit(4));
            list.Add(Tower.Middle_Tier_1, receivedTowers.GetBit(3));
            list.Add(Tower.Top_Tier_3, receivedTowers.GetBit(2));
            list.Add(Tower.Top_Tier_2, receivedTowers.GetBit(1));
            list.Add(Tower.Top_Tier_1, receivedTowers.GetBit(0));
        }
    }
}
