using Dota2Api.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota2Api.ConvertableClasses
{
    public class Hero
    {
        public string name { get; private set; }
        public HeroID id { get; private set; }
        public string localizedName { get; private set; }
    }
}
