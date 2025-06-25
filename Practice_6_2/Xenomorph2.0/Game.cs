using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Xenomorph2._0;

namespace KsenomorphGame
{
    internal class Game // фасад
    {
        ////////////////////////////////////// фасад //////////////////////////////////////
        private static Game game; // я сделал паттерн фасад с паттерном одиночка что бы он был один и доступен во всем проекте
        private Game() { }
        public static Game getInstance()
        {
            if (game == null)
            {
                game = new Game();
            }
            return game;
        }
        ////////////////////////////////////// ходы //////////////////////////////////////
        private int gameStep = 0;
        public int GetGameStep()
        {
            return gameStep;
        }
        ////////////////////////////////////// фракции //////////////////////////////////////
        private List<Fraction> fractions = new List<Fraction>(); // главный лист фракций
        private List<string> ActiveFraction = new List<string>(); // лист еще живых фракций
        private List<int> ActiveFractionIndex = new List<int>(); // индекс еще живых фракций
        public void UpdateActiveFraction() // обновление списка имен фракций
        {
            ActiveFraction.Clear();
            ActiveFractionIndex.Clear();
            for (int i = 0; i < fractions.Count; i++)
            {
                if (fractions[i].isLife)
                {
                    ActiveFraction.Add(fractions[i].name);
                    ActiveFractionIndex.Add(i);
                }
            }
        }
        public List<string> GetActiveFractions() // получение списка имен фракций
        {
            return ActiveFraction;
        }
        public List<int> GetActiveFractionsIndex() // получение
        {
            return ActiveFractionIndex;
        }
        public void GameLoad() // наполнение мира всяким многим в лист fractions
        {
            // планеты
            Planet PTerra = new Planet("Терра", "Загрезненная, но любимая планета империума, так как там зарадился империум.");
            Planet PUpeter = new Planet("марс", "Пусстынная планета, пустая и не приспасобленна к жизни.");
            Planet PHorrud = new Planet("Хоруд", "Теплая, влажная планета с кислотными дождями.");
            // листы планет
            List<Planet> LPXenomorph = new List<Planet>(); LPXenomorph.Add(PHorrud);
            List<Planet> LPHuman = new List<Planet>(); LPHuman.Add(PTerra);
            List<Planet> LPXen = new List<Planet>(); LPXen.Add(PUpeter);
            // гены
            Gene GXenomorph = new Gene("Ксеноморф", "Стандартный ген ксеноморфов.", 12, 8, 3, 3);
            Gene GHuman = new Gene("Хомосапиенс", "Хомосапиенс, существо слабое но очень умное.", 8, 2, 2, 12);
            Gene GXen = new Gene("Зенос", "Ген небывалой выжеваемости, дающий возможность захватить многие миры.", 6, 4, 4, 4);
            // формы жизни
            FormOfLife FOLXenomorph = new FormOfLife("Ксеноморф стандарт", "Пугающий захватчик галактик, идеальный хищник, в крови котоого циркулирует кислота!", GXenomorph);
            FormOfLife FOLHuman = new FormOfLife("Человек", "Умственно развитый социальный ораганизм, но очень слабый.", GHuman);
            FormOfLife FOLXen = new FormOfLife("Зен", "Захватчики из другого мира, бмногое неизвестно!", GXen);
            // листы формы жизни
            List<FormOfLife> LFOLXenomorph = new List<FormOfLife>();
            List<FormOfLife> LFOLHuman = new List<FormOfLife>();
            List<FormOfLife> LFOLXen = new List<FormOfLife>();
            // заполнение литса
            LFOLXenomorph.Add(FOLXenomorph);
            LFOLHuman.Add(FOLHuman);
            LFOLXen.Add(FOLXen);
            // фракции
            Fraction FPlayer = new Fraction("Рой", "Общий разум под управлением королев и короля.", LFOLXenomorph, LPXenomorph);
            Fraction FHuman = new Fraction("Империум Человечества", "Доминирующий разумный вид Галактики.", LFOLHuman, LPHuman);
            Fraction FXen = new Fraction("Зен", "Группа видов с огромной выживаемостью, управляется огромным друвним существом из другого мира", LFOLXen, LPXen);
            // командиры
            Comander CXking = new Comander("Император ксеноморфов", "Король хорошо командует атакой, но и защищает", 3, 1);
            Comander CXqueen1 = new Comander("Императрица кримсон", "Власть королевы на поле битвы дает защиту", 0, 4);
            Comander CXqueen2 = new Comander("Императрица даедалус", "Власть королевы воодушевляет атаку", 4, 0);
            Comander CXqueen3 = new Comander("Императрица диадема", "Власть королевы, которая во всем хороша", 2, 2);
            Comander CHImperator = new Comander("Бессмертный мператор", "Родился примерно за 9 000 лет до н.э. Именно он объединил враждующие остатки человечества и повёл их на путь возрождения утраченной звёздной империи.", 5, 0);
            Comander CXGabenBaby = new Comander("Неизвестный", "Не известное огромное и сильное сущетсво.", 2, 1);
            // заполнение командиров
            FPlayer.comanders.Add(CXking);
            FPlayer.comanders.Add(CXqueen1);
            FPlayer.comanders.Add(CXqueen2);
            FPlayer.comanders.Add(CXqueen3);
            FHuman.comanders.Add(CHImperator);
            FXen.comanders.Add(CXGabenBaby);
            // флоты
            SpaceFleet SFXeSpaceFleet = new SpaceFleet("Нейро жуки", "Открыли космическую экспансию для ксеноморфов", 12, 10);
            SpaceFleet SFHSpaceFleet = new SpaceFleet("Имперский флот", "Открыли космическую экспансию для ксеноморфов", 16, 20);
            SpaceFleet SFXSpaceFleet = new SpaceFleet("Телепортация", "Открыли меж-вселенную экспансию для зеносов", 10, 10);
            // заполнение флотов
            FPlayer.spaceFleets.Add(SFXeSpaceFleet);
            FHuman.spaceFleets.Add(SFHSpaceFleet);
            FXen.spaceFleets.Add(SFXSpaceFleet);
            // лист фракций
            fractions.Add(FPlayer);
            fractions.Add(FHuman);
            fractions.Add(FXen);
        }
        ////////////////////////////////////// вывод списков //////////////////////////////////////
        public List<string> GetComanderList() // список командиров
        {
            List<string> comanders = new List<string>();
            for (int i = 0; i < fractions[0].comanders.Count; i++)
            {
                comanders.Add(fractions[0].comanders[i].name);
            }
            return comanders;
        }
        public List<string> GetBioWeaponList() // список био оружия
        {
            List<string> bioWeapons = new List<string>();
            for (int i = 0; i < fractions[0].bioWeapons.Count; i++)
            {
                bioWeapons.Add(fractions[0].bioWeapons[i].name);
            }
            return bioWeapons;
        }
        public List<string> GetGeneList() // список генов
        {
            List<string> genes = new List<string>();
            for (int i = 0; i < fractions[0].geneStealed.Count; i++)
            {
                genes.Add(fractions[0].geneStealed[i].name);
            }
            return genes;
        }
        public List<string> GetSpaceFleetList() // список био оружия
        {
            List<string> spaceFeet = new List<string>();
            for (int i = 0; i < fractions[0].spaceFleets.Count; i++)
            {
                spaceFeet.Add(fractions[0].spaceFleets[i].name);
            }
            return spaceFeet;
        }
        ////////////////////////////////////// управление //////////////////////////////////////
        bool isAtacked = false;
        public bool GetIsAtacked()
        {
            return isAtacked;
        }
        public void IsGameOver()
        {
            if (fractions[0].isLife == false)
            {
                MessageBox.Show($"Вы проиграли... Поздравляю с тем что ты дошел до {gameStep} хода!", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
        public void GameUpdate()
        {
            gameStep++;
            IsGameOver();
            for (int i = 0; i < fractions.Count; i++)
            {
                fractions[i].ReproductionFormOfLive();
            }
        }
        public void PlayerSkip() // пропуск хода
        {
            GameUpdate();
            isAtacked = false;
        }
        public string PlayerWar(int indexFraction, int indexComander, int indexBioWeapon, int indexSpaceFleet) // война
        {
            isAtacked = true;
            return fractions[0].War(fractions[indexFraction], fractions[0].comanders[indexComander], fractions[0].bioWeapons[indexBioWeapon], fractions[0].spaceFleets[indexSpaceFleet]);
        }
        public bool PlayerCreateFormOfLife(string name, string description, int indexGene1, int indexGene2)
        {
            bool isCreated = fractions[0].CreateFormOfLive(name, description, fractions[0].geneStealed[indexGene1], fractions[0].geneStealed[indexGene2]);
            if (isCreated)
            {
                fractions[0].formsOfLife[fractions[0].formsOfLife.Count - 1].genes[1] = fractions[0].geneStealed[indexGene1];
                fractions[0].formsOfLife[fractions[0].formsOfLife.Count - 1].genes[2] = fractions[0].geneStealed[indexGene2];
                fractions[0].formsOfLife[fractions[0].formsOfLife.Count - 1].UpdateStats();
            }
            return isCreated;
        }
        public void PlayerCreateBioWeapon(string name, int indexGene1, int indexGene2, int indexGene3)
        {
            fractions[0].CreateBioWeapon(name, fractions[0].geneStealed[indexGene1], fractions[0].geneStealed[indexGene2], fractions[0].geneStealed[indexGene3]);
        }
        ////////////////////////////////////// прокачка //////////////////////////////////////
        public int skillPoints = 0;
        public void SkillPointsUp(int Num)
        {
            skillPoints += Num;
        }
        public int GetSkillPoint()
        {
            return skillPoints;
        }
        protected int[] lvlMissChanceInts = new int[3] {20, 10, 0};
        protected int[] lvlKritChanceInts = new int[3] {80, 70, 60};
        protected double[] lvlKritNumInts = new double[3] {1.6, 2, 2.4};
        public int lvlMissChance = 0;
        public int lvlKritChance = 0;
        public int lvlKritNum = 0;
        public bool PlayerLVLUP(int lvlupMissChance, int lvlupKritChance, int lvlupKritNum)
        {
            if (Math.Abs(lvlupMissChance - lvlMissChance) + Math.Abs(lvlupKritChance - lvlKritChance) + Math.Abs(lvlKritNum - lvlupKritNum) <= skillPoints && skillPoints - Math.Abs(lvlupMissChance - lvlMissChance) + Math.Abs(lvlupKritChance - lvlKritChance) + Math.Abs(lvlKritNum - lvlupKritNum) >= 0)
            {
                skillPoints -= Math.Abs(lvlupMissChance - lvlMissChance) + Math.Abs(lvlupKritChance - lvlKritChance) + Math.Abs(lvlupKritNum - lvlKritNum);
                lvlMissChance = lvlupMissChance;
                lvlKritChance = lvlupKritChance;
                lvlKritNum = lvlupKritNum;
                fractions[0].chanceOfMiss = lvlMissChanceInts[lvlupMissChance];
                fractions[0].chanceOfkrit = lvlKritChanceInts[lvlupKritChance];
                fractions[0].criticalAttack =  lvlKritNumInts[lvlKritNum];
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetStatsLvlLore()
        {
            string stats = string.Empty;
            stats += "шанс промаха = " + fractions[0].chanceOfMiss + " %." + Environment.NewLine;
            stats += "шанс крита = " + (100 - fractions[0].chanceOfkrit) + " %." + Environment.NewLine;
            stats += "сила крита = " + (fractions[0].criticalAttack * 100) + " %." + Environment.NewLine;
            return stats;
        }
        /////////////////////////////////////// вывод информации ///////////////////////////////////////
        public string GetLoreFraction(int indexFraction) // лор своей фракции
        {
            Fraction fraction = fractions[indexFraction];
            string Lore = string.Empty;
            Lore += "-----*:фракция:*-----" + Environment.NewLine;
            Lore += fraction.GetLore();
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Командование*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.comanders.Count; i++)
            {
                Lore += fraction.comanders[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Формы жизни*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.formsOfLife.Count; i++)
            {
                Lore += fraction.formsOfLife[i].GetLore();
                Lore += "Население = " + fraction.formsOfLifeCount[i] + Environment.NewLine;
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Технологии био оружия*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.bioWeapons.Count; i++)
            {
                Lore += fraction.bioWeapons[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Украденые гены*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.geneStealed.Count; i++)
            {
                Lore += Lore += fraction.geneStealed[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Планеты*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.planets.Count; i++)
            {
                Lore += fraction.planets[i].GetLore();
            }
            Lore += Environment.NewLine; Lore += Environment.NewLine;
            Lore += "*-*Космический флот*-*:" + Environment.NewLine;
            for (int i = 0; i < fraction.spaceFleets.Count; i++)
            {
                Lore += fraction.spaceFleets[i].GetLore();
            }
            return Lore;
        }
        public string GetFractionsLore()
        {
            string fractionsLore = string.Empty;
            for (int i = 0; i < fractions.Count; i++)
            {
                fractionsLore += fractions[i].GetLore() + Environment.NewLine + Environment.NewLine;
            }
            return fractionsLore;
        }
        public string GetFormsOfLifeLore()
        {
            string formsOfLifeLore = string.Empty;
            for (int i = 0; i < fractions.Count; i++)
            {
                for (int j = 0; j < fractions[i].formsOfLife.Count; j++)
                {
                    formsOfLifeLore += fractions[i].formsOfLife[j].GetLore() + Environment.NewLine + Environment.NewLine;
                }
            }
            return formsOfLifeLore;
        }
        public string GetGenesLore()
        {
            string genesLore = string.Empty;
            for (int i = 0; i < fractions.Count; i++)
            {
                for (int j = 0; j < fractions[i].formsOfLife.Count; j++)
                {
                    genesLore += fractions[i].formsOfLife[j].genes[0].GetLore();
                    genesLore += "Статы:" + Environment.NewLine;
                    genesLore += fractions[i].formsOfLife[j].genes[0].GetStatsLore() + Environment.NewLine + Environment.NewLine;
                }
            }
            return genesLore;
        }
        public string GetPlanetsLore()
        {
            string PlanetsLore = string.Empty;
            for (int i = 0; i < fractions.Count; i++)
            {
                for (int j = 0; j < fractions[i].planets.Count; j++)
                {
                    PlanetsLore += fractions[i].planets[j].GetLore() + Environment.NewLine + Environment.NewLine;
                }
            }
            return PlanetsLore;
        }
        public string GetSpaceFleetLore()
        {
            string SpaceFleetLore = string.Empty;
            for (int i = 0; i < fractions.Count; i++)
            {
                for (int j = 0; j < fractions[i].spaceFleets.Count; j++)
                {
                    SpaceFleetLore += fractions[i].spaceFleets[j].GetLore() + Environment.NewLine + Environment.NewLine;
                }
            }
            return SpaceFleetLore;
        }
    }
}