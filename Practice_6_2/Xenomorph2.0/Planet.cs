using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class Planet
    {
        public string name;
        public string description;
        public Planet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string GetLore()
        {
            string lore = string.Empty;
            lore += "Планета:" + Environment.NewLine;
            lore += "Название - " + name + Environment.NewLine;
            lore += "Описание - " + description + Environment.NewLine;
            return lore;
        }
    }
}
