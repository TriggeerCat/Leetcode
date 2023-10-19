using System;

namespace _844.BackspaceStringCompare
{
    public static class Solution {
        private static string Convert(string str)
        {
            string result = "";
            int buffer = 0;
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '#') 
                    buffer++;
                else
                {
                    if (buffer > 0)
                        buffer--;
                    else
                        result += str[i];
                }
            }
            
            return result;
        }
        
        public static bool BackspaceCompare(string s, string t) {
            return Convert(s) == Convert(t);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            Console.WriteLine(Solution.BackspaceCompare(s, t));
        }
    }
}