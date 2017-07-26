using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dota2Api.Enums;

namespace Dota2Api.HelperClasses {
    public class HeroPick {
        public HeroID character { get; private set; }
        public HeroID[] bestAgainst { get; private set; }
        public HeroID[] badAgainst { get; private set; }
        public ItemID[] bestItems { get; private set; }
        public ItemID[] counterItems { get; private set; }
        public AbilityID[] counterAbilities { get; private set; }
        public AbilityID[] bestAgainstAbilities { get; private set; }
        public AbilityID[] friendAbilities { get; private set; }
        public HeroID[] bestFirends { get; private set; }

        public HeroPick(HeroID character, 
            HeroID[] bestAgainst,
            HeroID[] badAgainst,
            ItemID[] bestItems,
            ItemID[] counterItems,
            AbilityID[] counterAbilities,
            AbilityID[] bestAgainstAbilities,
            AbilityID[] friendAbilities,
            HeroID[] bestFirends) {
            this.character = character;
            this.bestAgainst = bestAgainst;
            this.badAgainst = badAgainst;
            this.bestItems = bestItems;
            this.counterItems = counterItems;
            this.counterAbilities = counterAbilities;
            this.bestAgainstAbilities = bestAgainstAbilities;
            this.friendAbilities = friendAbilities;
            this.bestFirends = bestFirends;
        }
    }
}
