using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace TheTreeOfLife
{
    public class Player 
    {
    
        private int lvl = 1;
        private string weapon = ""; 
        private string name = "";
        private int gold = 10;
        private int expLimit = 10;
        private int exp = 0 ;
        private int health = 10;
        private int damage = 1;
        private int armorValue = 0;
        private int potion = 5;
        private int weaponValue = 1;
        //end of player values
       
        
        public string Name { get { return name; } set { name = value; } }
        //.public string PClass { get { return pClass; } set { pClass = value; } }
        public int XP { get { return exp; } set { exp = value; } }
        public int XPL { get { return expLimit; } set { expLimit = value; } }
        public string Weapon { get { return weapon; } set { weapon = value; } }
        public int Level { get { return lvl; } set { lvl = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Damage { get { return damage; } set { damage = value; } }    
        public int ArmorValue { get { return armorValue; } set { armorValue = value; } }
        public int Potion { get { return potion; } set { potion = value; } }
        public int WeaponValue { get { return weaponValue; } set { weaponValue = value; } }
       

    }
}
