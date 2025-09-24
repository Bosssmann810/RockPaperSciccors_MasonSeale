using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciccors_MasonSeale
{
    internal class Program
    {
        static int playerscore = 0;
        static int aiscore = 0;
        static Random RNG = new Random();
        static string choice = "";
        static bool keepgoing = true;
        static int shoot = 0;

        static void Main(string[] args)
        {
            while (keepgoing == true)
            {
                scoreboard();
                playerturn();
                aiturn();
                workitout();
                endgame();
                Console.ReadKey();
            }
        }
        static void scoreboard()
        {
            Console.Clear();
            Console.WriteLine($"PLayer Score: {playerscore}      AI score: {aiscore}");
        }
        static void playerturn()
        {
            Console.WriteLine("Please make your choice (in all lowercase please):");
            while (true)
            {
                choice = Console.ReadLine();
                if(choice == "rock")
                {
                    break;
                }
                else if (choice == "paper")
                {
                    break;
                }
                else if (choice == "sciccors")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid try again.");
                }
            }
            
        }
        static void endgame()
        {
            if (playerscore >= 3)
            {
                Console.WriteLine("You have won 3 rounds congratulations.");
                keepgoing = false;
            }
            else if(aiscore >= 3)
            {
                Console.WriteLine("The ai has won 3 round, better luck next time");
                keepgoing = false;
            }
            else
            {
                return;
            }
     
        }
        static void aiturn()
        {
            shoot = RNG.Next(1, 3);
            if (shoot == 1)
            {
                Console.WriteLine("The AI chose rock");

            }
            else if (shoot == 2)
            {
                Console.WriteLine("The AI chose paper");
            }
            else if (shoot == 3)
            {
                Console.WriteLine("The AI chose sciccors");
            }
            //1 rock 2 paper 3 sciccors
        }
        static void workitout()
        {
            if(choice == "rock")
            {
                if (shoot == 1)
                {
                    
                    Console.WriteLine("no points");
                }
                if (shoot == 2)
                {
                    
                    Console.WriteLine("AI scores");
                    aiscore++;
                }
                if (shoot == 3)
                {
                    
                    Console.WriteLine("You scored");
                    playerscore++;
                }

            }
            if (choice == "paper")
            {
                if(shoot == 1)
                {
                    Console.WriteLine("You scored");
                    playerscore++;

                }
                if(shoot == 2)
                {
                    Console.WriteLine("no points");
                }
                if(shoot == 3)
                {
                    Console.WriteLine("AI scores");
                    aiscore++;
                }
            }
            if (choice == "sciccors")
            {
                if (shoot == 1)
                {
                    Console.WriteLine("AI scores");
                    aiscore++;
                }
                if (shoot == 2)
                {
                    Console.WriteLine("You scored");
                    playerscore++;
                }
                if (shoot == 3)
                {
                    Console.WriteLine("no points");
                }

            }
            Console.WriteLine("Press any key to continue.");
        }
    }
}
