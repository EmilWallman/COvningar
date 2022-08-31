using System;

namespace COvningar2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum;

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2)
            {
                sum = Math.Pow(num1, 4);
            }

            else
            {
                sum = num1 + num2;
            }

            Console.WriteLine(sum);
        }
    }
}
