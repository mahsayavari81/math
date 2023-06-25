using System;

namespace Project
{
    class Test1
    {
        public static void Main()
        {
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x:");
            int y = Convert.ToInt32(Console.ReadLine());

            Calc(x, y);
        }
        private static void Calc(int x, int y)
        {
            double result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));

            Console.WriteLine("\nResualt is: " + result);
        }
    }
}