using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1;
            string[] compOption = { "R", "P", "s" };
            Random rand = new Random();

            while (true)
            {
                Console.Write("Type q to quit or anything to start: ");
                string startgame = Console.ReadLine().ToLower();
                if (startgame == "q")
                {
                    break;

                }
                else
                {
                    Console.Write("Choose R for Rock P for Paper and S for Scissors: ");
                    player1 = Console.ReadLine().ToLower();
                    String Compchoice = compOption[rand.Next(compOption.Length)];
                    if (player1 == "r")
                    {
                        if (Compchoice == "R")
                        {
                            Console.WriteLine("Tie");
                        }
                        else if (Compchoice == "P")
                        {
                            Console.WriteLine("You Loss");
                        }

                        else
                        {
                            Console.WriteLine("You win");

                        }

                    }
                    else if (player1 == "p")
                    {
                        if (Compchoice == "R")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (Compchoice == "P")
                        {
                            Console.WriteLine("Tie");
                        }
                        else
                        {
                            Console.WriteLine("You Loss");

                        }
                    }
                    else if (player1 == "s")
                    {
                        if (Compchoice == "R")
                        {
                            Console.WriteLine("You Loss");
                        }
                        else if (Compchoice == "P")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                        {
                            Console.WriteLine("Tie");
                        }

                    }
                    else
                    {
                        Console.WriteLine("You Choose a wrong option");
                    }
                }
            }
        }
    }
}
