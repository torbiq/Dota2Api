using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using Dota2Api.ConvertableClasses;

namespace Dota2Api {
    class Program {

        //public static Dictionary<Character, HeroPick> counterPicks = new Dictionary<Character, HeroPick> {
        //    { Character.antimage, new HeroPick(Character.antimage,
        //        new Character[] {
        //            Character.axe,
        //            Character.bane,
        //            Character.bloodseeker,
        //            Character.disruptor,
        //            Character.doom_bringer,
        //            Character.drow_ranger,
        //            Character.legion_commander,
        //            Character.meepo,
        //            Character.night_stalker,
        //            Character.obsidian_destroyer,
        //            Character.phantom_assassin,
        //            Character.slardar,
        //            Character.shadow_demon,
        //            Character.templar_assassin,
        //            Character.tiny,
        //            Character.troll_warlord,
        //        },
        //        new Character[] {
        //            Character.ancient_apparition,
        //            Character.arc_warden,
        //            Character.rattletrap,
        //            Character.elder_titan,
        //            Character.medusa,
        //            Character.morphling,
        //            Character.phoenix,
        //            Character.pugna,
        //            Character.spectre,
        //            Character.storm_spirit,
        //            Character.undying,
        //            Character.venomancer,
        //            Character.skeleton_king,
        //            Character.zuus,
        //            Character.lich,
        //            Character.necrolyte,
        //            Character.oracle,
        //            Character.leshrac,
        //            Character.furion,
        //            Character.tinker,
        //            Character.arc_warden,
        //            Character.shredder,
        //            Character.slark,
        //            Character.nevermore,
        //            Character.clinkz,
        //            Character.bristleback,
        //            Character.nyx_assassin,
        //            Character.magnataur,
        //        },
        //        new Item[] {
        //            Item.item_power_treads,
        //            Item.item_magic_wand,
        //            Item.item_bfury,
        //            Item.item_manta,
        //        },
        //        new Item[] {
        //            Item.item_black_king_bar,
        //            Item.item_sphere,
        //            Item.item_arcane_boots,
        //            Item.item_sheepstick,
        //            Item.item_abyssal_blade,
        //            Item.item_orchid,
        //        },
        //        new Ability[] {
        //            Ability.axe_berserkers_call,
        //            Ability.axe_counter_helix,
        //            Ability.bane_fiends_grip,
        //            Ability.bane_nightmare,
        //            Ability.bloodseeker_rupture,
        //            Ability.bloodseeker_blood_bath,
        //            Ability.disruptor_glimpse,
        //            Ability.disruptor_static_storm,
        //            Ability.doom_bringer_doom,
        //            Ability.drow_ranger_silence,
        //            Ability.drow_ranger_marksmanship,
        //            Ability.legion_commander_duel,
        //            Ability.night_stalker_crippling_fear,
        //            Ability.obsidian_destroyer_arcane_orb,
        //            Ability.obsidian_destroyer_sanity_eclipse,
        //            Ability.obsidian_destroyer_astral_imprisonment,
        //            Ability.obsidian_destroyer_essence_aura,
        //            Ability.phantom_assassin_blur,
        //            Ability.phantom_assassin_coup_de_grace,
        //            Ability.slardar_slithereen_crush,
        //            Ability.slardar_bash,
        //            Ability.slardar_amplify_damage,
        //            Ability.shadow_demon_disruption,
        //            Ability.shadow_demon_soul_catcher,
        //            Ability.shadow_demon_shadow_poison,
        //            Ability.templar_assassin_refraction,
        //            Ability.templar_assassin_meld,
        //            Ability.tiny_craggy_exterior,
        //            Ability.tiny_avalanche,
        //            Ability.tiny_toss,
        //        },
        //        new Ability[] {
        //            Ability.ancient_apparition_ice_blast,
        //            Ability.arc_warden_magnetic_field,
        //            Ability.arc_warden_tempest_double,
        //            Ability.rattletrap_power_cogs,
        //            Ability.elder_titan_echo_stomp,
        //            Ability.medusa_mana_shield,
        //            Ability.medusa_stone_gaze,
        //            Ability.morphling_morph,
        //            Ability.morphling_waveform,
        //            Ability.morphling_replicate,
        //            Ability.phoenix_supernova,
        //            Ability.pugna_decrepify,
        //            Ability.spectre_spectral_dagger,
        //            Ability.spectre_dispersion,
        //            Ability.storm_spirit_ball_lightning,
        //            Ability.undying_tombstone,
        //            Ability.skeleton_king_reincarnation,
        //        },
        //        new Ability[] {
        //            Ability.bane_fiends_grip,
        //            Ability.bounty_hunter_track,
        //            Ability.dazzle_shallow_grave,
        //            Ability.dark_seer_vacuum,
        //            Ability.invoker_emp,
        //            Ability.invoker_alacrity,
        //            Ability.lion_mana_drain,
        //            Ability.lion_voodoo,
        //            Ability.lion_impale,
        //            Ability.magnataur_shockwave,
        //            Ability.magnataur_skewer,
        //            Ability.magnataur_empower,
        //            Ability.magnataur_reverse_polarity,
        //            Ability.omniknight_repel,
        //            Ability.oracle_purifying_flames,
        //            Ability.shadow_demon_disruption,
        //            Ability.slardar_amplify_damage,
        //            Ability.treant_living_armor,
        //        },
        //        new Character[] {
        //            Character.bane,
        //            Character.bounty_hunter,
        //            Character.dazzle,
        //            Character.dark_seer,
        //            Character.invoker,
        //            Character.lion,
        //            Character.magnataur,
        //            Character.omniknight,
        //            Character.oracle,
        //            Character.shadow_demon,
        //            Character.slardar,
        //            Character.treant,
        //        })
        //    },
        //    { Character.axe, new HeroPick(Character.axe,
        //        new Character[] {
        //           Character.doom_bringer,
        //           Character.jakiro,
        //           Character.life_stealer,
        //           Character.necrolyte,
        //           Character.obsidian_destroyer,
        //           Character.shadow_demon,
        //           Character.spectre,
        //           Character.ursa,
        //           Character.shredder,
        //           Character.venomancer,
        //           Character.viper,
        //           Character.drow_ranger,
        //           Character.bristleback,
        //           Character.crystal_maiden,
        //           Character.batrider,
        //           Character.arc_warden,
        //           Character.winter_wyvern,
        //        },
        //        new Character[] {
        //            Character.antimage,
        //            Character.broodmother,
        //            Character.chaos_knight,
        //            Character.dazzle,
        //            Character.huskar,
        //            Character.legion_commander,
        //            Character.furion,
        //            Character.phantom_assassin,
        //            Character.phantom_lancer,
        //            Character.terrorblade,
        //            Character.weaver,
        //            Character.meepo,
        //            Character.lycan,
        //            Character.faceless_void,
        //            Character.troll_warlord,
        //            Character.juggernaut,
        //            Character.slark,
        //        },
        //        new Item[] {
        //            Item.item_cyclone,
        //            Item.item_force_staff,
        //            Item.item_silver_edge,
        //            Item.item_diffusal_blade,
        //            Item.item_mekansm,
        //            Item.item_skadi,
        //        },
        //        new Item[] {
                    
        //        },
        //        new Ability[] {
                    
        //        },
        //        new Ability[] {
                    
        //        },
        //        new Ability[] {
        //            Ability.dark_seer_vacuum,
        //            Ability.dark_seer_ion_shell,
        //            Ability.dark_seer_surge,
        //            Ability.dazzle_shallow_grave,
        //            Ability.enigma_midnight_pulse,
        //            Ability.enigma_black_hole,
        //            Ability.disruptor_kinetic_field,
        //            Ability.disruptor_static_storm,
        //            Ability.magnataur_reverse_polarity,
        //            Ability.sandking_epicenter,
        //            Ability.skywrath_mage_mystic_flare,
        //            Ability.tiny_toss,
        //            Ability.witch_doctor_maledict,
        //            Ability.witch_doctor_death_ward,
        //        },
        //        new Character[] {
        //            Character.dark_seer,
        //            Character.dazzle,
        //            Character.enigma,
        //            Character.disruptor,
        //            Character.magnataur,
        //            Character.sand_king,
        //            Character.skywrath_mage,
        //            Character.tiny,
        //            Character.venomancer,
        //            Character.witch_doctor,
        //        })
        //    },
        //    //{ Character.bane, new HeroPick(Character.bane,
        //    //    new Character[] {

        //    //    },
        //    //    new Character[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Character[] {

        //    //    })
        //    //},
        //    //{ Character.bane, new HeroPick(Character.bane,
        //    //    new Character[] {

        //    //    },
        //    //    new Character[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Character[] {

        //    //    })
        //    //},
        //    //{ Character.bane, new HeroPick(Character.bane,
        //    //    new Character[] {

        //    //    },
        //    //    new Character[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Character[] {

        //    //    })
        //    //},
        //    //{ Character.bane, new HeroPick(Character.bane,
        //    //    new Character[] {

        //    //    },
        //    //    new Character[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Item[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Ability[] {

        //    //    },
        //    //    new Character[] {

        //    //    })
        //    //},
        //    { Character.abaddon, new HeroPick(Character.abaddon,
        //        new Character[] {
        //            Character.axe,
        //            Character.doom_bringer,
        //            Character.lina,
        //            Character.storm_spirit,
        //            Character.windrunner,
        //            Character.obsidian_destroyer,
        //            Character.slark,
        //            Character.lion,
        //            Character.undying,
        //            Character.ancient_apparition,
        //            Character.shadow_demon,
        //            Character.nyx_assassin,
        //            Character.night_stalker,
        //            Character.silencer,
        //        },
        //        new Character[] {
        //            Character.death_prophet,
        //            Character.mirana,
        //            Character.bane,
        //            Character.batrider,
        //            Character.beastmaster,
        //            Character.chen,
        //            Character.techies,
        //            Character.bloodseeker,
        //            Character.necrolyte,
        //            Character.huskar,
        //            Character.venomancer,
        //            Character.phoenix,
        //        },
        //        new Item[] {
        //            Item.item_tranquil_boots,
        //            Item.item_mekansm,
        //            Item.item_magic_wand,
        //            Item.item_urn_of_shadows,
        //        },
        //        new Item[] {
        //            Item.item_orchid,
        //            Item.item_bloodthorn,
        //            Item.item_cyclone,
        //            Item.item_silver_edge,
        //            Item.item_dagon,
        //            Item.item_ethereal_blade,
        //        },
        //        new Ability[] {
        //            Ability.lina_laguna_blade,
        //            Ability.lion_finger_of_death,
        //            Ability.lion_voodoo,
        //            Ability.undying_tombstone,
        //            Ability.undying_decay,
        //            Ability.obsidian_destroyer_astral_imprisonment,
        //            Ability.obsidian_destroyer_arcane_orb,
        //            Ability.obsidian_destroyer_sanity_eclipse,
        //            Ability.slark_essence_shift,
        //            Ability.axe_culling_blade,
        //            Ability.doom_bringer_doom,
        //            Ability.ancient_apparition_ice_blast,
        //            Ability.shadow_demon_demonic_purge,
        //        },
        //        new Ability[] {
        //            Ability.death_prophet_exorcism,
        //            Ability.mirana_arrow,
        //            Ability.bane_nightmare,
        //            Ability.bane_fiends_grip,
        //            Ability.batrider_sticky_napalm,
        //            Ability.batrider_flaming_lasso,
        //            Ability.batrider_flamebreak,
        //            Ability.batrider_firefly,
        //        },
        //        new Ability[] {
        //            Ability.wisp_overcharge,
        //            Ability.axe_berserkers_call,
        //            Ability.legion_commander_duel,
        //            Ability.centaur_double_edge,
        //            Ability.centaur_hoof_stomp,
        //            Ability.oracle_purifying_flames,
        //            Ability.oracle_false_promise,
        //            Ability.oracle_fortunes_end,
        //        },
        //        new Character[] {
        //            Character.storm_spirit,
        //            Character.phantom_assassin,
        //            Character.wisp,
        //            Character.axe,
        //            Character.legion_commander,
        //            Character.centaur,
        //            Character.oracle,
        //            Character.sven,
        //        })
        //    }
        //};

        //private static Character[] GetBestCounters(Character[] against, Character[] with) {
        //    Stack<Character> returnedCharacters = new Stack<Character>();
        //    Dictionary<Character, int> repeatedCharacters = new Dictionary<Character, int>();
        //    int againstLength = against.Length;
        //    for (int i_against = 0; i_against < againstLength; i_against++) {
        //        if (counterPicks.ContainsKey(against[i_against])) {
        //            Character[] badAgainst = counterPicks[against[i_against]].badAgainst;
        //            int badLength = badAgainst.Length;
        //            for (int i_bad = 0; i_bad < badLength; i_bad++) {
        //                Character badAgainstCharacter = badAgainst[i_bad];
        //                if (repeatedCharacters.ContainsKey(badAgainstCharacter)) {
        //                    repeatedCharacters[badAgainstCharacter]++;
        //                }
        //                else {
        //                    repeatedCharacters.Add(badAgainstCharacter, 1);
        //                }
        //            }
        //        }
        //    }
        //    while (repeatedCharacters.Count != 0) {
        //        int repeatedCount = repeatedCharacters.Count;
        //        var minCoincidenceCharacter = repeatedCharacters.ElementAt(0);
        //        foreach (var element in repeatedCharacters) {
        //            if (element.Value < minCoincidenceCharacter.Value) {
        //                minCoincidenceCharacter = element;
        //            }
        //        }
        //        returnedCharacters.Push(minCoincidenceCharacter.Key);
        //        repeatedCharacters.Remove(minCoincidenceCharacter.Key);
        //    }
        //    return returnedCharacters.ToArray();
        //}

        //private static Item[] GetBestItems(Character picked, Character[] against, Character[] with) {
        //    Stack<Character> returnedCharacters = new Stack<Character>();
        //    Dictionary<Character, int> repeatedCharacters = new Dictionary<Character, int>();
        //    int againstLength = against.Length;
        //    for (int i_against = 0; i_against < againstLength; i_against++) {
        //        if (counterPicks.ContainsKey(against[i_against])) {
        //            Character[] badAgainst = counterPicks[against[i_against]].badAgainst;
        //            int badLength = badAgainst.Length;
        //            for (int i_bad = 0; i_bad < badLength; i_bad++) {
        //                Character badAgainstCharacter = badAgainst[i_bad];
        //                if (repeatedCharacters.ContainsKey(badAgainstCharacter)) {
        //                    repeatedCharacters[badAgainstCharacter]++;
        //                }
        //                else {
        //                    repeatedCharacters.Add(badAgainstCharacter, 1);
        //                }
        //            }
        //        }
        //    }
        //    while (repeatedCharacters.Count != 0) {
        //        int repeatedCount = repeatedCharacters.Count;
        //        var minCoincidenceCharacter = repeatedCharacters.ElementAt(0);
        //        foreach (var element in repeatedCharacters) {
        //            if (element.Value < minCoincidenceCharacter.Value) {
        //                minCoincidenceCharacter = element;
        //            }
        //        }
        //        returnedCharacters.Push(minCoincidenceCharacter.Key);
        //        repeatedCharacters.Remove(minCoincidenceCharacter.Key);
        //    }
        //    return returnedCharacters.ToArray();
        //}

        private static void Main(string[] args) {
            const string KEY = "8BFC2C10E3D1E95B85DCF6AAD861782D";
            //string content = GetStringAsync("https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V001/?match_id=3323746296&key=" + KEY).Result;
            //Console.Write(content);

            var ps = new PlayerSlot("128");
            var ts = new TowerStatus("2046");
            var ts1 = new TowerStatus("4");
            var br1 = new BarracksStatus("3");
            var br2 = new BarracksStatus("63");
            Console.WriteLine(ps.position + " " + ps.side);
            foreach (var tower in ts.list) {
                Console.WriteLine(tower.Key + " " + tower.Value);
            }
            foreach (var tower in ts1.list) {
                Console.WriteLine(tower.Key + " " + tower.Value);
            }
            foreach (var barrack in br1.list) {
                Console.WriteLine(barrack.Key + " " + barrack.Value);
            }
            foreach (var barrack in br2.list) {
                Console.WriteLine(barrack.Key + " " + barrack.Value);
            }
            Console.ReadKey();
        }

        private static async Task<string> GetStringAsync(string address) {
            try {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address);
                request.Method = HttpMethod.Get;
                HttpClient client = new HttpClient();
                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.Forbidden) {
                    throw new System.Exception("Api-Key most likely wrong");
                }
                else if (response.StatusCode == HttpStatusCode.ServiceUnavailable) {
                    throw new System.Exception("Server is busy or api-call limit exceeded. Please wait 30 seconds and try again. Call only ~1 request/second.");
                }

                string content = await response.Content.ReadAsStringAsync();

                return content;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
