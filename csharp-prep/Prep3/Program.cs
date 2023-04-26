using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,20);    

        Console.Write("Guess a number: ");

        int guess = -1;       

        while (number != guess)
        {
            Console.Write("Guess a number: ");
            
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");    
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}