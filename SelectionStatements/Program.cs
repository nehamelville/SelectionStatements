using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //var favNumber = 100;

            Console.Write("Guess What your favourite number is :");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");

            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Congratulations!!You are right!!");
            }
            else
            {
                Console.WriteLine("Never mind!!");
            }
        }
    }
}
