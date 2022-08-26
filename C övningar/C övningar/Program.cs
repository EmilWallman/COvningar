using System;

namespace C_övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int go = 0;
            Console.WriteLine("insert number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine("Här är summan av talen: " + sum);
         
        }
    }
}
