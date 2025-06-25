using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class FormOfLife
    {
        //описание
        public string name;
        public string description;
        //гены
        public Gene[] genes = new Gene[3];
        public float attack;
        public float protection;
        public float survivalRate;
        public float intelligence;
        public FormOfLife(string name_, string description_, Gene gene0)
        {
            name = name_;
            description = description_;
            genes[0] = gene0;
            genes[1] = gene0;
            genes[2] = gene0;
            UpdateStats();
        }
        public void UpdateStats() // обновление статов с генами
        {
            float buff = 1 + (1 / (genes[0].intelligence + genes[1].intelligence + genes[2].intelligence));
            attack = (((genes[0].attack + genes[1].attack + genes[2].attack) / 3) * buff);
            protection = (((genes[0].protection + genes[1].protection + genes[2].protection) / 3) * buff);
            survivalRate = (((genes[0].survivalRate + genes[1].survivalRate + genes[2].survivalRate) / 3) * buff);
            intelligence = ((buff - 1) * 100);
        }
        public Gene GeneSteal() // кража гена
        {
            Random random = new Random();
            return genes[random.Next(0, 3)];
        }
        public string GetLore() //получение информации
        {
            string lore = string.Empty;
            lore += "Описание формы жизни:" + Environment.NewLine;
            lore += "название - " + name + Environment.NewLine;
            lore += "описание - " + description + Environment.NewLine;
            lore += "Гены:" + Environment.NewLine;
            genes[0].GetLore();
            genes[1].GetLore();
            genes[2].GetLore();
            lore += "Статы:" + Environment.NewLine;
            lore += "атака =\t" + attack + Environment.NewLine;
            lore += "защита =\t" + protection + Environment.NewLine;
            lore += "выжеваемость =\t" + survivalRate + Environment.NewLine;
            lore += "интелект =\t" + intelligence + " %" + Environment.NewLine;
            return lore;
        }
    }
}
