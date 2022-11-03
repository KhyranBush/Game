using System.Collections;
using System.Collections.Generic;
using System;

namespace TheTreeOfLife
{
    public class Player

    {
        private int lvl = 1;
        private string weapon = "";
        private string name = "";
        private int gold = 10;
        private int expLimit = 10;
        private int exp = 0;
        private int health = 10;
        private int damage = 1;
        private int armorValue = 0;
        private int potion = 5;
        private Room positon;

        public string Name { get { return name; } set { name = value; } }
        public int XP { get { return exp; } set { exp = value; } }
        public int XPL { get { return expLimit; } set { expLimit = value; } }
        public string Weapon { get { return weapon; } set { weapon = value; } }
        public int Level { get { return lvl; } set { lvl = value; } }
        public int Gold { get { return gold; } set { gold = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int ArmorValue { get { return armorValue; } set { armorValue = value; } }
        public int Potion { get { return potion; } set { potion = value; } }
        public Room Position { get { return positon; } set { positon = value; } }

        public void player(string name, int lvl, string weapon, int gold, int xp, int health, int dmg, int armor, int potions, Room pos)

        {
            name = Name;
            lvl = Level;
            weapon = Weapon;
            gold = Gold;
            xp = XP;
            health = Health;
            dmg = Damage;
            armor = ArmorValue;
            potions = Potion;
            pos = Position;
        }
       


        private Room _currentRoom = null;
        public Room CurrentRoom
        {
            get
            {
                return _currentRoom;
            }
            set
            {
                _currentRoom = value;
            }
        }

        public Player(Room room)
        {
            _currentRoom = room;
        }

        public void WaltTo(string direction)
        {
            Room nextRoom = this.CurrentRoom.GetDoor(direction);
            if (nextRoom != null)
            {
                this.CurrentRoom = nextRoom;
                this.OutputMessage("\n" + this.CurrentRoom.Description());
            }
            else
            {
                this.OutputMessage("\nThere is no door on " + direction);
            }
        }

        public void OutputMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
