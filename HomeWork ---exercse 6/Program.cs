using System;

namespace HomeWork____exercse_6
{
    class Program
    {
        static void Main(string[] args)
        {


            int num1, num2;
            Console.WriteLine("Input first num");
            num1 = Convert.ToInt32(Console.ReadLine());
         

            Console.WriteLine("Input second num");
            num2 = Convert.ToInt32(Console.ReadLine());
     

            if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} is bigger");
            }
            else
            {
                Console.WriteLine($"Number {num2} is bigger");
            }

      

            if (num1 % 2 == 0) Console.WriteLine($"Number {num1} is eaven");
            else Console.WriteLine($"Number {num1} is odd");

            if (num2 % 2 == 0) Console.WriteLine($"Number {num2} is eaven");
            else Console.WriteLine($" Njumber {num2} is odd");


            Console.ReadLine();
        }
    }
}
