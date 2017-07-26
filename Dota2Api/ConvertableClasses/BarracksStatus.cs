using Dota2Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dota2Api.Extensions;

namespace Dota2Api.ConvertableClasses {
    /// <summary>
    /// Barracks status.
    /// </summary>
    public class BarracksStatus {
         /// <summary>
        /// Team barrack status.
        /// </summary>
         public Dictionary<Barrack, bool> list { get; private set; }
         
         public BarracksStatus(string parsedSByte) {
             // A particular teams tower status is given as an 8-bit unsigned integer.
             // The rightmost 6 bits represent the barracks belonging to that team; 
             // see below for a visual representation.
             // ┌─┬───────────── Not used.
             // │ │ ┌─────────── Bottom Ranged
             // │ │ │ ┌───────── Bottom Melee
             // │ │ │ │ ┌─────── Middle Ranged
             // │ │ │ │ │ ┌───── Middle Melee
             // │ │ │ │ │ │ ┌─── Top Ranged
             // │ │ │ │ │ │ │ ┌─ Top Melee
             // │ │ │ │ │ │ │ │
             // 0 0 0 0 0 0 0 0
    
             byte receivedBarracks = byte.Parse(parsedSByte);
    
             this.list = new Dictionary<Barrack, bool>();
             list.Add(Barrack.Bottom_Ranged, receivedBarracks.GetBit(5));
             list.Add(Barrack.Bottom_Melee, receivedBarracks.GetBit(4));
             list.Add(Barrack.Middle_Ranged, receivedBarracks.GetBit(3));
             list.Add(Barrack.Middle_Melee, receivedBarracks.GetBit(2));
             list.Add(Barrack.Top_Ranged, receivedBarracks.GetBit(1));
             list.Add(Barrack.Top_Melee, receivedBarracks.GetBit(0));
         }
     }
}
