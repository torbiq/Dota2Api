using System;
using System.Collections.Generic;
using System.Text;

namespace Dota2Api.Enums
{
    public enum LobbyType {
        Invalid = -1,
        PublicMatchmaking = 0,
        Practise = 1,
        Tournament = 2,
        Tutorial = 3,
        CoopWithBots = 4,
        TeamMatch = 5,
        SoloQueue = 6,
        Ranked = 7,
        OneVsOneMid = 8,
    }
}
