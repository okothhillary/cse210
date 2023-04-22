using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter;
        
        

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
          letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        


        char secondChar = grade[1];
        char  firstChar = grade[0];

        if (secondChar >= 7 && number > 60 && firstChar != 9 )
        {
            Console.WriteLine($"Your grade is {letter + "+"}");
        }
        else if (secondChar >= 4 && number > 59)
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (secondChar < 3 && number >= 60)
        {
            Console.WriteLine($"Your grade is {letter + "-"}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        if (number>= 70)
        {
            Console.WriteLine("You passed! Keep up.");
        }
        else
        {
            Console.WriteLine("You Failed. Try Again");
        }
    }
}