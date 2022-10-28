using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;


namespace TheTreeOfLife
{

    //all of the interfaces for the game 
    
    public interface enemies
    {
        void firstBoss(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void secondBoss(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void thirdBoss(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void fourthBoss(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void floor1Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void floor2Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void floor3Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);
        void floor4Mobs(string name, int pos, int Level, int health, int power, int exp, int gold, int loot);


    }
    public interface weapon
    {
        void basicSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc);
        void basicStaff(int hlth, int LvlR, int armor, int damage, Room positon, string desc);
        void silverSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc);
        void initiateStaff(int hlth, int LvlR, int armor, int damage, Room positon, string desc);
        void serratedSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc);
        void lilithsEdge(int hlth, int LvlR, int armor, int damage, Room positon, string desc);


    }
    
   




}
