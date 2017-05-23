using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Let's play Rock, paper, scissors?");
                Console.Write("Type rock, paper, or scissors: ");
                string userAnswer = Console.ReadLine();
                string computerAnswer = "";
                Random rnd = new Random();
                int value = rnd.Next(0, 33);
                //To make computer choose answer
                if (value <= 11)
                {
                    computerAnswer = "rock";
                }
                else if (value <= 22)
                {
                    computerAnswer = "paper";
                }
                else
                {
                    computerAnswer = "scissors";
                }
                //user picks rock
                if (userAnswer == "rock" && computerAnswer == "scissors")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You Win!");
                    Console.ReadLine();
                }
                else if (userAnswer == "rock" && computerAnswer == "paper")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You lose!");
                    Console.ReadLine();
                }
                //user picks paper
                else if (userAnswer == "paper" && computerAnswer == "scissors")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You lose!");
                    Console.ReadLine();
                }
                else if (userAnswer == "paper" && computerAnswer == "rock")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You win!");
                    Console.ReadLine();
                }
                //user picks scissors
                else if (userAnswer == "scissors" && computerAnswer == "rock")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You lose!");
                    Console.ReadLine();
                }
                else if (userAnswer == "scissors" && computerAnswer == "paper")
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". You win!");
                    Console.ReadLine();
                }
                //if it is a tie
                else
                {
                    Console.WriteLine("You chose " + userAnswer + ", Bob chose " + computerAnswer + ". It is a tie!");
                    Console.ReadLine();
                }



            }

        
    }
}
