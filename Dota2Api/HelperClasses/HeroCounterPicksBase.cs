using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dota2Api.Enums;

namespace Dota2Api.HelperClasses {
    public class HeroPick {
        public Character character { get; private set; }
        public Character[] bestAgainst { get; private set; }
        public Character[] badAgainst { get; private set; }
        public Item[] bestItems { get; private set; }
        public Item[] counterItems { get; private set; }
        public Ability[] counterAbilities { get; private set; }
        public Ability[] bestAgainstAbilities { get; private set; }
        public Ability[] friendAbilities { get; private set; }
        public Character[] bestFirends { get; private set; }

        public HeroPick(Character character, 
            Character[] bestAgainst,
            Character[] badAgainst,
            Item[] bestItems,
            Item[] counterItems,
            Ability[] counterAbilities,
            Ability[] bestAgainstAbilities,
            Ability[] friendAbilities,
            Character[] bestFirends) {
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
