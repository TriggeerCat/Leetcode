using System;
using System.Linq;

namespace _1503.LastMomentBeforeAllAntsFallOutOfAPlank
{
    internal class Program
    {
        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        
        public int GetLastMoment(int n, int[] left, int[] right)
        {
            if (left.Length == 0)
                left = new int[] {0};

            if (right.Length == 0)
                right = new int[] { n };
            
            return (Max(left.Max(), n - right.Min()));
        }
        
        public static void Main(string[] args)
        {
            int n = 7;
            int[] left = {0,1};
            int[] right = {7};
            Console.WriteLine(new Program().GetLastMoment(n, left, right));
        }
    }
}