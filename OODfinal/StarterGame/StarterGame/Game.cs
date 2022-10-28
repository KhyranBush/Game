using System.Collections;
using System.Collections.Generic;
using System;

namespace TheTreeOfLife
{
    public class Game
    {
        private Player _player;
        private Parser _parser;
        private bool _playing;

        public Game()
        {
            _playing = false;
            _parser = new Parser(new CommandWords());
            _player = new Player(CreateWorld());
        }

        public Room CreateWorld()
        {
            //world is built by floors there are five floors each with a varying amount of rooms 
            Room startingPoint = new Room("in a bright white room with a door in the distance\n\nThe door is dark, irradiatng a strange silver and black luminescence,\n" + "\nThe room gives you an ominous feeling inside..");
            
            Room FloorOr1 = new Room("in a slightly dim room with braziers crackling on the walls and strange noises sounding off in the distance");//floor one room one 
            Room FloorOr2 = new Room("in a slightly dim room with braziers crackling on the walls and strange noises sounding off in the distance");//floor one room one 
            Room FloorOr3 = new Room("in a slightly dim room with braziers crackling on the walls and strange noises sounding off in the distance");//floor one room one 
            Room FloorOr4 = new Room("in a slightly dim room with braziers crackling on the walls and strange noises sounding off in the distance");//floor one room one 
            Room FloorOr5 = new Room("in a slightly dim room with braziers crackling on the walls and strange noises sounding off in the distance");//floor one room one 
           //-----------floor two-------------------------
            Room Floortr1= new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            Room Floortr2 = new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            Room Floortr3 = new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            Room Floortr4 = new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            Room Floortr5 = new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            Room Floortr6 = new Room("A large room with a bright red light beeming its rays into your eyes, it almost makes it hard to see the monsters swarming around in the distance...");
            //------------FLOOR 3----------------------------
            Room FloorTr1 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr2 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr3 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr4 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr5 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr6 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            Room FloorTr7 = new Room("A gigantic room with a pond and fire that work in tandem to add to its humidity, you notice snake-like creature slithering around throughout the numerous appletrees...");
            //---------------FLOOR FOUR-----------------------
            Room Floorfr1 = new Room("in the green in from of Schuster Center");
            Room Floorfr2 = new Room("in the green in from of Schuster Center");
            Room Floorfr3 = new Room("in the green in from of Schuster Center");
            Room Floorfr4 = new Room("in the green in from of Schuster Center");
            Room Floorfr5 = new Room("in the green in from of Schuster Center");
            Room Floorfr6 = new Room("in the green in from of Schuster Center");
            Room Floorfr7 = new Room("in the green in from of Schuster Center");
            Room Floorfr8 = new Room("in the green in from of Schuster Center");
            Room Floorfr9 = new Room("in the green in from of Schuster Center");
            //--------------------FLOOR FIVE FINAL FLOOR----------
            Room FloorFr1 = new Room("in University Hall");
            Room FloorFr2 = new Room("in University Hall");
            Room FloorFr3 = new Room("in University Hall");
            Room FloorFr4 = new Room("in University Hall");
            Room FloorFr5 = new Room("in University Hall");
            Room FloorFr6 = new Room("in University Hall");
            Room FloorFr7 = new Room("in University Hall");
            Room FloorFr8 = new Room("in University Hall");
            Room FloorFr9 = new Room("in University Hall");
            //-------------------------------TRAP ROOMS-------------------------
            Room TrapRoom = new Room("A room with eerie depictions of people seemingly fighting and dying to monsters in the dungeon, There is a creepy statue in the distance");
            Room TrapRoom2 = new Room("in the parking deck");
            Room TrapRoom3 = new Room("in the Schuster Center");




            startingPoint.SetDoor("north", FloorOr1);

            
          //  FloorOr1.SetExit("north", FloorTwo);
          //  FloorOr1.SetExit("West", TrapRoom);
           // FloorTwo.SetExit("north", FloorThree);
            //FloorTwo.SetExit("east", TrapRoom2);
           //FloorThree.SetExit("north", FloorFour);
            //FloorFour.SetExit("north", FloorFour);
            //FloorFour.SetExit("west", TrapRoom3);
        









            return startingPoint;
        }

        /**
     *  Main play routine.  Loops until end of play.
     */
        public void Play()
        {

            // Enter the main command loop.  Here we repeatedly read commands and
            // execute them until the game is over.

            bool finished = false;
            while (!finished)
            {
                Console.Write("\n>");
                Command command = _parser.ParseCommand(Console.ReadLine());
                if (command == null)
                {
                    Console.WriteLine("I don't understand...");
                }
                else
                {
                    finished = command.Execute(_player);
                }
            }
        }


        public void Start()
        {
            _playing = true;
            _player.OutputMessage(Welcome());
        }

        public void End()
        {
            _playing = false;
            _player.OutputMessage(Goodbye());
        }

        public string Welcome()
        {
            return "|The Tree Of Life: Ultimate Ascension| \n\n\n" + "The secrets of the universe are just within your grasp..." + "\n\nType 'help' if you need help.\n\n" + "\n-----------------------------------\n\n" + _player.CurrentRoom.Description() + "\n\n";
        }

        public string Goodbye()
        {
            return "\nThank you for playing, Goodbye. \n";
        }

    }
}
