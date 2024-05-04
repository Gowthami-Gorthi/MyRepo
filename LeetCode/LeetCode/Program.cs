using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Polindrome");
            LongestPolindrome longestPolindrome=new LongestPolindrome();
            Console.WriteLine(longestPolindrome.LongestPalindrome(Convert.ToString(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
