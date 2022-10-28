using System;
using System.Collections.Generic;
using System.Text;

namespace TheTreeOfLife
{
    public class Weapons : weapon
    {

        private Room position;
        public Room Position { get { return position; } set { position = value; } }

        IDictionary<int, string> weaponNames = new Dictionary<int, string>();
        Room room = new Room();



        public void basicSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {
            desc = "Basic sword with rust laden on its once majestic blade, its handle has an undecipherable description in a strange language";
            hlth = 2;
            LvlR = 1;
            armor = 2;
            damage = 1;
            positon = positon;


        }
        public void basicStaff(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {
            desc = "Wooden staff with a glowing blue orb on the end irradiating a blue-black luminecence";
            hlth = 1;
            LvlR = 1;
            armor = 1;
            damage = 2;
            positon = positon;

        }
        public void silverSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {
        }
        public void initiateStaff(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {

        }
        public void serratedSword(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {
        }
        public void lilithsEdge(int hlth, int LvlR, int armor, int damage, Room positon, string desc)
        {
        }

    }

   }  
    



