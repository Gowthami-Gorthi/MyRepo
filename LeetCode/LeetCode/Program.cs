using LeetCode.Problems;
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
            Console.WriteLine("Reverse Prefix of Word");
            ReversePrefix reversePrefix = new ReversePrefix();
            Console.WriteLine(reversePrefix.ReversePrefi("abcdefd",'d'));

            Console.WriteLine("Largest Positive Integer That Exists With Its Negative");
            LargestPositiveInteger largestPositiveInteger = new LargestPositiveInteger();
            int[] nums = {-1, 2, -3, 3};
            Console.WriteLine(largestPositiveInteger.FindMaxK(nums));

            Console.WriteLine("Compare Version Numbers");
            CompareVersions compareVersions = new CompareVersions();
            Console.WriteLine(compareVersions.CompareVersion("1.0", "1.0.0"));

            Console.WriteLine("Boats to Save People");
            BoatsToSavePeople boatsToSavePeople = new BoatsToSavePeople();
            int[] boats = { 3, 2, 2, 1 };
            Console.WriteLine(boatsToSavePeople.NumRescueBoats(boats,3));

            Console.WriteLine("Longest Polindrome");
            LongestPolindrome longestPolindrome=new LongestPolindrome();
            Console.WriteLine(longestPolindrome.LongestPalindrome(Convert.ToString(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
