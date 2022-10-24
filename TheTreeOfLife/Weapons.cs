using System;
using System.Collections.Generic;
using System.Text;

namespace TheTreeOfLife
{
   public class Weapons
    {
        private int dmg = 0;
        private int armor = 0;
        private int htlh = 0;
        public void basicSword(int dmg, int armor, int hlth)
        {
            //the weapons  lore wise provide the player with "armor" as well ass bonus attack and hlth points 
            //warriors do less dmg but take less dmg from mobs 
            dmg = 1;
            armor = 2;
            hlth = 2;

        }
        public void basicStaff(int dmg, int armor, int hlth)
        {
            //the weapons  lore wise provide the player with "armor" as well ass bonus attack and hlth points 
            //mages do more damage but take more dmg 
            dmg = 2;
            armor = 0;
            hlth = 1;

        }


    }
}
