using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class BioWeapon
    {
        public string name;
        public Gene[] genes = new Gene[3];
        public float Attack;
        public float intelegence;
        public BioWeapon(string name, Gene gene0, Gene gene1, Gene gene2, List<FormOfLife> formsOfLife)
        {
            this.name = name;
            genes[0] = gene0;
            genes[1] = gene1;
            genes[2] = gene2;
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                intelegence = formsOfLife[i].intelligence;
            }
            intelegence = intelegence / formsOfLife.Count;
            UpdateAttack();
        }
        private void UpdateAttack()
        {
            Attack = 1 / ((genes[0].attack + genes[1].attack + genes[2].attack) / 3 / intelegence);
        }
        public double GetAttack()
        {
            return Attack;
        }
        public string GetLore()
        {
            string lore = string.Empty;
            lore += "ген:" + name + Environment.NewLine;
            lore += "Название - " + name + Environment.NewLine;
            lore += "Гены:" + Environment.NewLine;
            genes[0].GetLore();
            genes[1].GetLore();
            genes[2].GetLore();
            return lore;
        }
    }
}
