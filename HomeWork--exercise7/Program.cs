using System;

namespace HomeWork__exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number from 1 to 3");
            int userInput = Convert.ToInt32(Console.ReadLine());


            switch (userInput)
            {

                case 1:
                    Console.WriteLine("You got a new car!​");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;

                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;

                default:
                    Console.WriteLine("Error..Dooode insert number from 1 to 3");
                    break;

            }

            Console.ReadLine();









        }
    }
}
