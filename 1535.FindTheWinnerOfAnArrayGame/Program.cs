using System;

namespace _1535.FindTheWinnerOfAnArrayGame
{
    internal class Program
    {
        public int GetWinner(int[] arr, int k)
        {
            int winner = arr[0];
            int winnerCount = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i == arr.Length - 1 && winnerCount < k)
                    return Math.Max(winner, arr[i]);
                    
                if (winner == Math.Max(winner, arr[i]))
                    winnerCount++;
                else
                {
                    winner = arr[i];
                    winnerCount = 1;
                }
                
                if (winnerCount == k)
                    return winner;
                
            }

            return 0;
        }
        
        public static void Main(string[] args)
        {
            int[] arr = {1,25,35,42,68,70};
            int k = 1;

            Console.WriteLine(new Program().GetWinner(arr, k));
        }
    }
}

// Треба, щоб було більше k разів підряд