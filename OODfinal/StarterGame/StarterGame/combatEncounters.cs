using System;
using System.Collections.Generic;
using System.Text;

namespace TheTreeOfLife
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using static System.Net.Mime.MediaTypeNames;

    namespace TheTreeOfLife
    {
        //This class is for npc fights 
        public class combatEncounters

        {
            Room room = new Room();
            Enemies enemy = new Enemies();


            public void Combat(Enemies enemy, Player p1)
            {
                Player player = new Player(room);
                Enemies en = new Enemies();
                Random rand = new Random();
                //Player player = new Player();
                string n = "";
                int pw = 0;
                int hlth = 0;
                int xp = 0;
            
               
               
                while (hlth > 0)
                {
                    string CombatUi = n + pw + "/" + hlth + "\n" +
                                      "-------------------------\n" +
                                      "| (A)ttack     (D)efend  |\n" +
                                      "|                        |\n" +
                                      "| (H)eal       (R)un     |\n" +
                                      "-------------------------\n" +
                                      "|Potions:| " + player.Potion + " |Health:| " + player.Health;
                    Console.WriteLine(CombatUi);
                    string input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "atttack" || input.ToLower() == "Attack" || input.ToLower() == "A")
                    {
                        int attack = rand.Next(0, p1ayer.dmg) + rand.Next(1, 4);
                        int damage = pw - player.ArmorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine(player.Name + " You attack the enemy using your" + player.Weapon + " You delt " + attack + "\n" +
                                          "The enemy attacks viciously and you lose " + damage + " health");

                        player.Health -= damage;
                        hlth -= attack;
                    }
                    if (input.ToLower() == "d" || input.ToLower() == "defend" || input.ToLower() == "Defend" || input.ToLower() == "D")
                    {
                        int attack = rand.Next(0, player.WeaponValue) / 2;
                        int damage = (pw / 4) - player.ArmorValue;
                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("You Hearken yout skin towards pain " + n + " Strikes you visciously\n" +
                                          "You have lost " + damage + "health");
                        hlth -= attack;
                        player.Health -= damage;



                    }
                    else if (input.ToLower() == "h" || input.ToLower() == "heal" || input.ToLower() == "Heal" || input.ToLower() == "H")
                    {
                        if (player.Potion == 0)
                        {
                            int damage = pw - player.ArmorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine("You are out of potions!" + "The enemy seeks this chance to attack and you lose " + damage + " Health");
                        }
                        else
                        {
                            Console.WriteLine("You luckily have potions, you heal for" + player.Potion + " health");
                            player.Health += player.Potion;
                        }




                    }
                    else if (input.ToLower() == "r" || input.ToLower() == "run" || input.ToLower() == "Run" || input.ToLower() == "R")
                    {
                        if (rand.Next(0, 2) == 0)
                        {
                            int damage = pw - player.ArmorValue;
                            if (damage < 0)
                                damage = 0;
                            Console.WriteLine("You attempt to flee yet " + n + " Strikes you thwarting your flee attempt\n" +
                                          "You have lost " + damage + "health");
                        }
                        else
                        {
                            Console.WriteLine("You have managed to escape as you run to the start of the dungeon\n\n" +
                                              "           press any key to continue...   ");


                        }
                        Console.ReadKey();

                    }
                    Console.ReadKey();
                    while (hlth <= 0)
                    {
                        if (hlth <= 0)
                        {
                            Console.WriteLine("The dastardly " + n + " Wails as space distorts and collapses around its hideous visage\n\n");
                            Console.WriteLine("You beat the " + n + " Congratulations!\n\n");
                            Console.WriteLine("The " + n + " gave you " + exp + " Experience");
                            player.XP += exp;
                            if (player.XP >= player.XPL)
                                player.Level += 1;
                            player.XP -= player.XPL;
                            player.XPL += 10;


                            Console.WriteLine("Your lvl " + player.Level);
                            Console.WriteLine("Your lvl " + player.XP);
                            Console.WriteLine("Do you wish Continue? " + player.Name);
                            Console.ReadKey();
                            break;
                        }
                    }

                }
            }
        }
    }
    }

