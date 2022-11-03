using System.Collections;
using System.Collections.Generic;
using System;

namespace TheTreeOfLife
{
    public class Room
    {
        private Dictionary<string, Room> _exits;
        private string _tag;
        public string Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }

        public Room() : this("No Tag"){}

        // Designated Constructor
        public Room(string tag)
        {
            _exits = new Dictionary<string, Room>();
            this.Tag = tag;
        }

        public void SetDoor(string exitName, Room room)
        {
            _exits[exitName] = room;
        }

        public Room GetDoor(string exitName)
        {
            Room room = null;
            _exits.TryGetValue(exitName, out room);
            return room;
        }

        public string GetDoors()
        {
            string exitNames = "There is a door to the...: ";
            Dictionary<string, Room>.KeyCollection keys = _exits.Keys;
            foreach (string exitName in keys)
            {
                exitNames += " " + exitName;
            }

            return exitNames;
        }

        public string Description()
        {
            return "You are " + this.Tag + ".\n *** " + this.GetDoors();
        }
    }
}
