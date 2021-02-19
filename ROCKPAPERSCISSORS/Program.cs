using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS!:");
            inputPlayer = Console.ReadLine();
            inputCPU = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("computer choice ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW! \n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    break;
                   
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("computer choice PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW! \n\n");
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    break;
                    
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("computer choice SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW! \n\n");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    break;
        
                default:
                    Console.WriteLine("invalid plx try again");
                    break;
            }
            Console.ReadLine();
        }
    }
}

        