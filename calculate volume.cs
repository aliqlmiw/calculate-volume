using System;
using System.Runtime.InteropServices;
namespace Project
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("please enter The sides of the cube:");
            Console.Write("L = ");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.Write("H = ");
            int H = Convert.ToInt32(Console.ReadLine());
            Console.Write("W = ");
            int W = Convert.ToInt32(Console.ReadLine());
            double show = Calc(L, H, W);
            Console.WriteLine("volume = {0}", show);
        }
        private static double Calc(int num1, int num2, int num3)
        {
            double Result = num1 * num2 * num3;
            return Result;
        }
    }
}