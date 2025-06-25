using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class Comander
    {
        public string name;
        public string description;
        public float buffAttack;
        public float buffProtected;
        public Comander(string name, string description, float buffAttack, float buffProtected)
        {
            this.name = name;
            this.description = description;
            this.buffAttack = buffAttack;
            this.buffProtected = buffProtected;
        }
        public string GetLore()
        {
            string lore = string.Empty;
            lore += "Командир:" + name + Environment.NewLine;
            lore += "имя - " + name + Environment.NewLine;
            lore += "история - " + description + Environment.NewLine;
            lore += "бафы:" + Environment.NewLine;
            lore += "атака - " + buffAttack + Environment.NewLine;
            lore += "защита - " + buffProtected + Environment.NewLine;
            return lore;
        }
    }
}
