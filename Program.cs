using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaxRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerClass;
            int playerHP;
            int playerDmg = 0;

            Console.WriteLine("Welcome to LaxRPG." + Environment.NewLine + "It's a strange new world, with monsters to fight and quests to complete." + Environment.NewLine + "Can you save the day?" + Environment.NewLine);

            Console.WriteLine("To begin, please choose your class:");
            Console.WriteLine("1. Paladin");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Ranger");
            Console.WriteLine("4. Rogue");

            string playerClassStr = Console.ReadLine();

            bool resolveClass = int.TryParse(playerClassStr, out playerClass);

            if(resolveClass == false)
            {
                Console.WriteLine("The value entered was not a number.");
                return;
            }

            switch(playerClass)
            {
                case 1:
                    playerHP = 10;
                    playerDmg = 10;
                    break;
                case 2:
                    playerHP = 7;
                    playerDmg = 13;
                    break;
                case 3:
                    playerHP = 9;
                    playerDmg = 11;
                    break;
                case 4:
                    playerHP = 8;
                    playerDmg = 12;
                    break;
                default:
                    playerDmg = 1;
                    playerHP = 1;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("A monster appears!  It has 20 HP.");
            int monsterHP = 20;

            Console.WriteLine("You attack it, but it fights back!");

            monsterHP -= playerDmg;

            Console.WriteLine("It has {0} health remaining.  You have {1} health remaining.", monsterHP, playerHP);

            while(monsterHP > 0 && playerHP > 0)
            {
                monsterHP -= playerDmg;
                playerHP--;

                Console.WriteLine("You attack it again!  It fights back again!");

                if(playerHP <= 0)
                {
                    Console.WriteLine("You have 0 health.  You've died :(");
                    Console.ReadLine();
                    return;
                }

                if(monsterHP >= 0)
                {
                    Console.WriteLine("It has {0} health remaining. You have {1} health remaining.", monsterHP, playerHP);
                }
                else if(monsterHP < 0)
                {
                    Console.WriteLine("It has 0 health remaining!");
                }
                
            }



            Console.ReadLine();

        }
    }
}
