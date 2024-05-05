using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ReversePrefix
    {
        /// <summary>
        /// Example 1:
        /// Input: word = "abcdefd", ch = "d"
        /// Output: "dcbaefd"
        /// Explanation: The first occurrence of "d" is at index 3. 
        /// Reverse the part of word from 0 to 3 (inclusive), the resulting string is "dcbaefd".
        /// 
        /// Example 2:
        /// Input: word = "xyxzxe", ch = "z"
        /// Output: "zxyxxe"
        /// Explanation: The first and only occurrence of "z" is at index 3.
        /// Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        /// 
        /// Example 3:
        /// Input: word = "abcd", ch = "z"
        /// Output: "abcd"
        /// Explanation: "z" does not exist in word.
        /// You should not do any reverse operation, the resulting string is "abcd".
        /// 
        /// Constraints:
        /// 1 <= word.length <= 250
        /// word consists of lowercase English letters.
        /// ch is a lowercase English letter.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        public string ReversePrefi(string word, char ch)
        {
            if (!word.Contains(ch))
            {
                return word;
            }
            int index = word.IndexOf(ch) + 1;
            return Reverse(word.Substring(0, index)) + word.Substring(index);
        }
        private string Reverse(string s)
        {
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse;
        }
    }
}
