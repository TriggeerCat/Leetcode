using System;
using System.Linq;

namespace _1921.EliminateMaximumNumberOfMonsters
{
    internal class Program
    {
        public int EliminateMaximum(int[] dist, int[] speed)
        {
            int length = dist.Length;
            float[] time = new float[length];
            for (int i = 0; i < length; i++)
                time[i] = (float)dist[i] /  speed[i];
            Array.Sort(time);
            for (int turn = 0; turn < length; turn++)
            {
                if (time[turn] <= turn)
                    return turn;
            }
            return length;
        }
        
        public static void Main(string[] args)
        {
            int[] dist = { 1, 1, 2, 3 };
            int[] speed = { 1, 1, 1, 1 };
            Console.WriteLine(new Program().EliminateMaximum(dist, speed));
        }
    }
}