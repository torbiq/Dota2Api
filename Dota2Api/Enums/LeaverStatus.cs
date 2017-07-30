namespace Dota2API.Enums {
    /// <summary>
    /// A list of states for leaving game (NONE means player didn't leave game, and DISCONNECTED means that player disconnected from that game).
    /// </summary>
    public enum LeaverStatus {
        /// <summary>
        /// Player is now in this game.
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Player is now disconnected from this game.
        /// </summary>
        DISCONNECTED = 1,
        /// <summary>
        /// Being disconnected for more than ~5 min.
        /// </summary>
        DISCONNECTED_TOO_LONG = 2,
        /// <summary>
        /// Player abandoned the game by clicking "abandon" button.
        /// </summary>
        ABANDONED = 3,
        /// <summary>
        /// AFK for too long time (doesn't count when).
        /// </summary>
        AFK = 4,
        /// <summary>
        /// Not connected to the game since start for less than ~5 min.
        /// </summary>
        NEVER_CONNECTED = 5,
        /// <summary>
        /// Not connected to the game since start for more than ~5 min.
        /// </summary>
        NEVER_CONNECTED_TOO_LONG = 6,
    }
}
