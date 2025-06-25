using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class Gene
    {
        public string name;
        public string description;
        public float attack;
        public float protection;
        public float survivalRate;
        public float intelligence;
        public Gene(string name_, string description_, int attack_, int protection_, int survivalRate_, int intelligence_)
        {
            name = name_;
            description = description_;
            attack = attack_;
            protection = protection_;
            survivalRate = survivalRate_;
            intelligence = intelligence_;
        }
        public string GetLore() // получение лора
        {
            string lore = string.Empty;
            lore += "ген:" + name + Environment.NewLine;
            lore += "Название - " + name + Environment.NewLine;
            lore += "Описание - " + description + Environment.NewLine;
            return lore;
        }
        public string GetStatsLore() // получение лора
        {
            string lore = string.Empty;
            lore += "атака:" + attack + Environment.NewLine;
            lore += "защита:" + protection + Environment.NewLine;
            lore += "выжеваемость:" + survivalRate + Environment.NewLine;
            lore += "интелект:" + intelligence + Environment.NewLine;
            return lore;
        }
    }
}
