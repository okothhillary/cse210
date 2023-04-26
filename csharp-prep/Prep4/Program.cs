using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)

    {  List<int> numbers = new List<int>();
       int number = -1;

       while (number != 0)       
       {
            Console.Write("Give me a number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);
       }
       
        int sum = numbers.Sum();

        int max = numbers.Max();

        double average = numbers.Average();

        Console.WriteLine($"The sum is {sum}");  

        Console.WriteLine($"The maximum number is {max}");  

        Console.WriteLine($"The average is {average}");

          

    }
}