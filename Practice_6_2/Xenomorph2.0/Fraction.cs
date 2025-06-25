using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenomorph2._0
{
    internal class Fraction
    {
        public string name;
        public string description;
        public bool isLife = true;
        public List<FormOfLife> formsOfLife;
        public List<int> formsOfLifeCount = new List<int>();
        public List<Planet> planets = new List<Planet>();
        public List<Gene> geneStealed = new List<Gene>();
        public List<Comander> comanders = new List<Comander>();
        public List<BioWeapon> bioWeapons = new List<BioWeapon>();
        public List<SpaceFleet> spaceFleets = new List<SpaceFleet>();
        private const double partOfFOLCountAttack = 0.05;
        public double criticalAttack = 1.2;
        public int chanceOfkrit = 90;
        public int chanceOfMiss = 40;
        public Fraction(string name, string description, List<FormOfLife> formsOfLife, List<Planet> planets)
        {
            this.name = name;
            this.description = description;
            this.formsOfLife = formsOfLife;
            geneStealed.Add(formsOfLife[0].genes[0]);
            formsOfLifeCount.Add(1000);
            this.planets = planets;
            BioWeapon bioWeapon = new BioWeapon("Стандартное", formsOfLife[0].genes[0], formsOfLife[0].genes[0], formsOfLife[0].genes[0], formsOfLife);
            bioWeapons.Add(bioWeapon);
        }
        public string LastWarHistory;
        public string War(Fraction fraction, Comander comander, BioWeapon bioWeapon, SpaceFleet spaceFleet) // Война
        {
            LastWarHistory = string.Empty;
            LastWarHistory += $"Война:{name} атака на {fraction.name}";
            //атакующий
            double attackerHP = 0;
            for (int i = 0; i < formsOfLifeCount.Count; i++)
            {
                attackerHP += formsOfLifeCount[i];
            }
            double attackerAT = 0;
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                attackerAT += formsOfLife[i].attack;
            }
            attackerAT = (attackerAT / formsOfLife.Count + comander.buffAttack + bioWeapon.Attack) * (spaceFleet.buffAttack / 10);
            double attackerPT = 0;
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                attackerPT += (formsOfLife[i].protection + comander.buffProtected) * (spaceFleet.buffProtected / 10);
            }
            attackerPT = attackerPT / formsOfLife.Count;
            LastWarHistory += Environment.NewLine +
                $"характиристики({name}):" + Environment.NewLine +
                $"атака - {Math.Round(attackerAT, 2)}" + Environment.NewLine +
                $"защита - {Math.Round(attackerPT, 2)}" + Environment.NewLine +
                $"хит поинтов - {attackerHP}" + Environment.NewLine;
            //защищающий
            double defencerHP = 0;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                defencerHP += fraction.formsOfLifeCount[i];
            }
            double defencerAT = 0;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                defencerAT += fraction.formsOfLife[i].attack;
            }
            defencerAT = defencerAT / fraction.formsOfLife.Count;
            double defencerPT = 0;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                defencerPT += fraction.formsOfLife[i].protection;
            }
            defencerPT = defencerPT / fraction.formsOfLife.Count;
            LastWarHistory += Environment.NewLine +
                $"характиристики({fraction.name}):" + Environment.NewLine +
                $"атака - {Math.Round(defencerAT, 2)}" + Environment.NewLine +
                $"защита - {Math.Round(defencerPT, 2)}" + Environment.NewLine +
                $"хит поинтов - {defencerHP}" + Environment.NewLine + Environment.NewLine;
            Random random = new Random();
            int step = 0;
            while (true)
            {
                step++;
                int chance = random.Next(0, 101);
                if (chance > chanceOfkrit)
                {
                    defencerHP -= attackerAT / defencerPT * attackerHP * partOfFOLCountAttack * criticalAttack;
                    LastWarHistory += $"Крит атака ({name}) = " + Math.Round(attackerAT / defencerPT * attackerHP * partOfFOLCountAttack * criticalAttack, 3) + Environment.NewLine + Environment.NewLine;
                }
                if (chance >= chanceOfMiss && chance <= chanceOfkrit)
                {
                    defencerHP -= attackerAT / defencerPT * attackerHP * partOfFOLCountAttack;
                    LastWarHistory += $"Атака ({name}) = " + Math.Round(attackerAT / defencerPT * attackerHP * partOfFOLCountAttack, 3) + Environment.NewLine + Environment.NewLine;
                }
                if (chance < chanceOfMiss)
                {
                    LastWarHistory += $"промах ({name})" + Environment.NewLine + Environment.NewLine;
                }
                if (defencerHP < 0)
                {
                    if (fraction.planets.Count == 1)
                    {
                        for (int i = 0; i < fraction.spaceFleets.Count; i++)
                        {
                            spaceFleets.Add(fraction.spaceFleets[i]);
                        }
                    }
                    LastWarHistory += Environment.NewLine + $"!победа ({name})!"; // Обьявление победы
                    Planet tempPlanet;// передача планеты
                    tempPlanet = fraction.planets[fraction.planets.Count - 1];
                    fraction.planets.RemoveAt(fraction.planets.Count - 1);
                    planets.Add(tempPlanet);
                    geneStealed.Add(fraction.formsOfLife[random.Next(formsOfLife.Count)].genes[random.Next(0, 3)]); // кража рандомного гена
                    for (int i = 0; i < fraction.formsOfLifeCount.Count; i++)
                    {
                        fraction.formsOfLifeCount[i] = Convert.ToInt32(fraction.formsOfLifeCount[i] * 0.8);
                    }
                    for (int i = 0; i < formsOfLifeCount.Count; i++)
                    {
                        formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * 0.9);
                    }
                    break;
                }
                chance = random.Next(0, 101);
                if (chance > chanceOfkrit)
                {
                    attackerHP -= defencerAT / defencerPT * defencerHP * partOfFOLCountAttack * criticalAttack;
                    LastWarHistory += $"Крит атака ({fraction.name}) = " + Math.Round(defencerAT / defencerPT * defencerHP * partOfFOLCountAttack * criticalAttack, 3) + Environment.NewLine + Environment.NewLine;
                }
                if (chance >= chanceOfMiss && chance <= chanceOfkrit)
                {
                    attackerHP -= defencerAT / defencerPT * defencerHP * partOfFOLCountAttack;
                    LastWarHistory += $"Атака ({fraction.name}) = " + Math.Round(defencerAT / defencerPT * defencerHP * partOfFOLCountAttack, 3) + Environment.NewLine + Environment.NewLine;
                }
                if (chance < chanceOfMiss)
                {
                    LastWarHistory += $"промах ({fraction.name})" + Environment.NewLine + Environment.NewLine;
                }
                if (attackerHP < 0)
                {
                    LastWarHistory += Environment.NewLine + $"!победа ({fraction.name})!";

                    for (int i = 0; i < fraction.formsOfLifeCount.Count; i++)
                    {
                        fraction.formsOfLifeCount[i] = Convert.ToInt32(fraction.formsOfLifeCount[i] * 0.9);
                    }

                    for (int i = 0; i < formsOfLifeCount.Count; i++)
                    {
                        formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * 0.8);
                    }
                    break;
                }
                if (step > 100)
                {
                    LastWarHistory += Environment.NewLine + "ничья?";
                    break;
                }
            }
            fraction.IsFractionLife(fraction);
            return LastWarHistory;
        }
        private bool IsFractionLife(Fraction fraction)
        {
            if (fraction.planets.Count == 0)
            {
                fraction.isLife = false;
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CreateFormOfLive(string name, string description, Gene gene2, Gene gene3)
        {
            if (formsOfLifeCount[0] > 1000)
            {
                FormOfLife newFormOfLive = new FormOfLife(name, description, formsOfLife[0].genes[0]);
                newFormOfLive.genes[1] = gene2;
                newFormOfLive.genes[2] = gene3;
                formsOfLife.Add(newFormOfLive);
                formsOfLifeCount[0] -= 1000;
                formsOfLifeCount.Add(1000);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CreateBioWeapon(string name, Gene gene0, Gene gene1, Gene gene2)
        {
            bioWeapons.Add(new BioWeapon(name, gene0, gene1, gene2, formsOfLife));
        }
        public void ReproductionFormOfLive()
        {
            for (int i = 0; i < formsOfLife.Count; i++)
            {
                formsOfLifeCount[i] = Convert.ToInt32(formsOfLifeCount[i] * (1 + formsOfLife[i].survivalRate / 100));
            }
        }
        public string GetLore()
        {
            string lore = string.Empty;
            lore += "Фракция:" + Environment.NewLine;
            lore += "Название - " + name + Environment.NewLine;
            lore += "Описание - " + description + Environment.NewLine;
            return lore;
        }
    }
}
