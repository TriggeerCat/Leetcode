using System;

namespace _342.PowerOfFour
{
    internal class Program
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n <= 0)
                return false;
            else
            {
                double log = Math.Log(n, 4);
                return Convert.ToInt32(log) == log;
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfFour(-2147483648));
        }
    }
}