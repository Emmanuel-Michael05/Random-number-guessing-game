using System;
namespace assignment_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 1; int max = 100;
            bool palyAgain = true;
            int guess;
            int guesses;
            int number;
            string response; string name;
            Console.Write("Enter your name:  ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ". Have fun playing!!");
            while (palyAgain)
            {
                guess = 0;
                guesses = 0;
                number = rnd.Next(min, max + 1);
                response = "";
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":  ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is  high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is  low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again: (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    palyAgain = true;
                }
                else if (response == "N")
                {
                    palyAgain = false;
                }
            }
            Console.WriteLine("Thanks " + name + " for playing ");
            Console.ReadKey();
        }
    }


}