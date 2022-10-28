using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheTreeOfLife
{
    public class Enemies : enemies
    {

        public Room position;
        private int health;
        private int power;
        private int exp;
        private int gold;
        private string loot;
        public int lvl;
        public void firstBoss(string name,int Level, int pos, int health, int power, int exp, int gold, int loot)
        {
            name = "Ethereal Spirit - Rohin, The First Ascender";
            pos = position;// floorOr4
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;

        }
        public void secondBoss(string name, int Level, int pos, int health, int power, int exp, int gold, int loot)
        {
            name = "Kaglalryn: Half-Dragon GateKeeper";
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;

        }
        public void thirdBoss(string name, int Level, int pos, int health, int power, int exp, int gold, int loot)
        {
            name = "Aeric Giant Slayer: The Berserker Warrior of Isaiel";
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;

        }
        public void fourthBoss(string name, int Level, int pos, int health, int power, int exp, int gold, int loot)
        {
            name = "Solomon Kingdoms's Bane:King Supreme of Isaiel";
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;

        }
        public void floor1Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot)
        {
            name = "Fire Scaled Tundragosa";
            Level = 2;
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;
        }

        public void floor2Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot)
        {
            name = "Shape-Shifting proto - Slime";
            Level = 3;
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;

        }
        public void floor3Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot)
        {
            name = "Spirit Knight of Chivalry";
            Level = 4;
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;
        }
        public void floor4Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot)
        {
            name = "Squire of the lost kingdom";
            Level = 5;
            pos = position;
            health = 5;
            power = 2;
            exp = 10;
            gold = 15;
            loot = 0;
        }
        IDictionary<int, string> mobNames = new Dictionary<int, string>(); 






    }
}

    
    

