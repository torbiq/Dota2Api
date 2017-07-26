using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses
{
    /// <summary>
    /// Represents ability upgrade info (abilityID, time and level).
    /// </summary>
    public class AbilityUpgrade
    {
        /// <summary>
        /// ID of the ability upgraded.
        /// </summary>
        public AbilityID abilityID { get; private set; }
        /// <summary>
        /// Time since match start that the ability was upgraded.
        /// </summary>
        public int time { get; private set; }
        /// <summary>
        /// The level of the player at time of upgrading.
        /// </summary>
        public Level level;

        public AbilityUpgrade(AbilityID abilityID, int time, Level level) {
            this.abilityID = abilityID;
            this.time = time;
            this.level = level;
        }
    }
}
