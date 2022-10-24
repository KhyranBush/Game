using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TheTreeOfLife
{
    public class GameWorld {
   
        public  void mainLoop()
        {
          Player player = new Player();

        Encounters encounters = new Encounters();
         

        Console.WriteLine("\n\nWelcome to the Tree of life, an ascension into a new adventure!\n\n");
                                                                                                                                                
                                                                                                                                                
                                                                                                                                        
            
            
            Console.WriteLine("\n\nWelcome to the beginning of your adventure dear adventurer\n\n A journey like this requires sacrifice and courageousness in the face of the unknown!\n\n Are you ready to face this danger?\n\n");
            Console.ReadKey();

            //from this point the game world will begin once user has selected a key
            Console.WriteLine("You awaken disheveled, pain irradiating throughout your body as if you have been ripped apart!\n\n" +
                              "You look around you confused, as you are in a different place than when you were awake\n\n" +
                              "You hear an echo from across the bright white room and decide to follow it\n\n" +
                              "from here dear traveler, your joruney begins\n\n" +
                              "You hear a voice within the distance yell in a calming voice.. 'WHAT IS YOUR NAME HERO?\n\n");
            Console.WriteLine("\n\nEnter your Name:");
            player.Name = Console.ReadLine();

            Console.WriteLine("  Oh " + player.Name + " hearken your ears to my tale of woe, seek me out at the far end of this floor\n\n");
            Console.WriteLine("You begin to walk forward to start your journey, but you notices an ethereal creature staring at you in the darkness\n\n");
            Console.WriteLine("The voice speaks to you again, this time sounding more urgent than  before" + " Do you wish to continue? Press any key to press forward\n\n");
            Console.ReadKey();

            Console.WriteLine("Theres no time! quickly\n\n" + "\ntwo items appear before you, a silver sword with specks of rust laden on its once glorious blade\n\n");
            Console.WriteLine("And a mysterious glistening staff seemingly irradiating a strange energy\n\n" + "Choose one! " + player.Name + " it is time to prove your worth to the heavens\n\n");
            Console.WriteLine("What weapon do you choose, a sword or a magical staff\n\n");
            player.Weapon = Console.ReadLine();
            
            

            Console.WriteLine("You pick up a " + player.Weapon + " It is time to fight!\n\n");
           
            Console.WriteLine("The Ethereal Spirit looks at your chaing from a shade of luminescence to an eer crimson red\n\n" + "It screams a guttural sound as it charges forth space seemingly bending to its will\n\n");
            Console.WriteLine(player.Name + "Assume your destiny!");
            Console.WriteLine("To continue, press any key");
            Console.ReadKey();
            encounters.FirstEnemy();
        }
        

        
        
    }
}
