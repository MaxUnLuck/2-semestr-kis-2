using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class SpaceFleet
    {
        public string name;
        public string description;
        public float buffAttack;
        public float buffProtected;
        public SpaceFleet(string name, string description, float buffAttack, float buffProtected)
        {
            this.name = name;
            this.description = description;
            this.buffAttack = buffAttack;
            this.buffProtected = buffProtected;
        }
        public string GetLore()
        {
            string lore = string.Empty;
            lore += "Флот:" + Environment.NewLine;
            lore += "название - " + name + Environment.NewLine;
            lore += "описание - " + description + Environment.NewLine;
            lore += "бафы:" + Environment.NewLine;
            lore += "атака - " + (buffAttack - 10) + Environment.NewLine;
            lore += "защита - " + (buffProtected - 10) + Environment.NewLine;
            return lore;
        }
    }
}
