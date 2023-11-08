using System;

namespace _2849.DetermineIfACellIsReachableAtAGivenTime
{
    internal class Program
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx && sy == fy)
                return t != 1;
            return (t >= Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy)));
        }
    
        public static void Main(string[] args)
        {
            Console.WriteLine(new Program().IsReachableAtTime(1, 4, 1, 2, 1));
        }
    }
}