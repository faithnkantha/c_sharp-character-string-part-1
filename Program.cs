using System;
class QuestionOne
{
    static void Main()
    {
        char letter;


        Console.WriteLine("Enter a number ,letter or special character");
        letter=Convert.ToChar(Console.ReadLine());
        if (char.IsDigit(letter))
            Console.WriteLine("You have entered a digit");
        else if (char.IsLetter(letter))
            Console.WriteLine("You have entered a letter");
        else
            Console.WriteLine("You have entered a special character");
    }
}