using System;
using Dota2API.Convertable;
using System.Collections.Generic;
using System.Threading;
using Dota2API.Enums;
using Dota2API.Core;

namespace Dota2API {
    class Program {
        public const string KEY = "8BFC2C10E3D1E95B85DCF6AAD861782D";

        [STAThread]
        private static void Main(string[] args) {
            var api = new DotaWebAPI(KEY);

            var heroes = api.GetHeroes();
            Console.WriteLine("Heroes received count = " + heroes.Count);

            var heroGameHistory = new Dictionary<HeroID, List<MatchDetails>>();

            for (int i_heroes = 0; i_heroes < heroes.Count; i_heroes++) {
                MatchHistoryRequest request = new MatchHistoryRequest();
                request.matchesRequested = 100;
                var hero = heroes[i_heroes];
                request.heroID = hero.id;
                request.gameMode = GameMode.RankedMatchmaking;
                Console.WriteLine("Made a request & chosen a hero " + hero.localizedName);
                while (true) {
                    Thread.Sleep(1100);
                    var matches = api.GetMatchHistory(request).matches;

                    if (matches.Count > 0) {
                        request.startAtMatchID = matches[matches.Count - 1].matchID - 1;
                        if (heroGameHistory.ContainsKey(request.heroID.Value)) {
                            heroGameHistory[hero.id].AddRange(matches);
                        }
                    }
                    else {
                        Console.WriteLine("No matches left.");
                        break;
                    }
                }
            }

            //foreach (var item in items) {
            //    if (item.id.ToString() != item.name) {
            //        Console.WriteLine(item.id + " " + item.name);
            //    }
            //}
            //Console.WriteLine(items[15].recipe);
            //Thread.Sleep(1500);

            //var match = Dota2API.Network.Dota2API.GetMatchDetails(KEY, result.matches[0].matchID);

            //Console.WriteLine(match.matchID);

            Console.ReadKey();
        }

    }
}
