using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var favoriteNumber = 21;

            Console.WriteLine("Try to guess my favorite number");

            var guess = int.Parse(Console.ReadLine());

            if (guess < favoriteNumber)
            {
                Console.WriteLine("too low");
            }
            else if (guess > favoriteNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("correct");
            }

            var team = Console.ReadLine();

            switch (team)
            {
                case "chiefs":
                    Console.WriteLine("The chiefs are in the superbowl");
                    break;
                case "patriots":
                    Console.WriteLine("The patriots are not in the superbowl");
                    break;
                default:
                    Console.WriteLine($"The {team} and 49er's are in the superbowl");
                    break;
              
            }
            int teamName = 3;
            switch (teamName)
            {
                case 0:
                    Console.WriteLine("Seahawks");
                    break;
                case 1:
                    Console.WriteLine("Chiefs");
                    break;
                case 2:
                    Console.WriteLine("Texans");
                    break;
                case 3:
                    Console.WriteLine("49er's");
                    break;
                case 4:
                    Console.WriteLine("Patriots");
                    break;
             
            }
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}


            var answer = 4;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            
            Console.WriteLine();
            
        }
    }
}
