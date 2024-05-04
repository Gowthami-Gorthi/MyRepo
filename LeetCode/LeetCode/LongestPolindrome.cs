using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestPolindrome
    {
        public string LongestPalindrome(string s)
        {
            int length = s.Length;
            if (length < 1 || length > 1000)
                return string.Empty;

            if (length == 1)
                return s;
            string max = s[0] + "";
            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = 0; j < i && s.Length >= i + j; j++)
                {
                    string che = s.Substring(i, j);
                    string ch = s.Substring(j, i);

                    if (!string.IsNullOrEmpty(che) && IsPolindrome(che) && max.Length < che.Length)
                        max = che;
                    else if (!string.IsNullOrEmpty(ch) && IsPolindrome(ch) && max.Length < ch.Length)
                        max = ch;
                }
            }
            return max;
        }

        private bool IsPolindrome(string s)
        {
            int n = s.Length;
            for (int i = 0; i <= s.Length / 2; i++)
            {
                if (s[i] != s[n - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
