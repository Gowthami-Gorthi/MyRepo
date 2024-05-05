using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class CompareVersions
    {
        /// <summary>
        /// 
        /// Example 1:
        /// Input: version1 = "1.01", version2 = "1.001"
        /// Output: 0
        /// Explanation: Ignoring leading zeroes, both "01" and "001" represent the same integer "1".
        /// 
        /// Example 2:
        /// Input: version1 = "1.0", version2 = "1.0.0"
        /// Output: 0
        /// Explanation: version1 does not specify revision 2, which means it is treated as "0".
        /// 
        /// Example 3:
        /// Input: version1 = "0.1", version2 = "1.1"
        /// Output: -1
        /// Explanation: version1's revision 0 is "0", while version2's revision 0 is "1". 0 < 1, so version1<version2.
        /// 
        /// </summary>
        public int CompareVersion(string version1, string version2)
        {
            string[] v1 = version1.Split('.'), v2 = version2.Split('.');
            int final = 0, i;
            for (i = 0; i < v1.Length && i < v2.Length; i++)
            {
                int res = Convert.ToInt32(v1[i]) - Convert.ToInt32(v2[i]);
                if (res >= 1 && final == 0)
                {
                    return ++final;
                }
                if (res <= -1 && final == 0)
                    return --final;
            }
            while (i < v1.Length && final == 0)
            {
                int res = Convert.ToInt32(v1[i++]);
                if (res >= 1)
                    return ++final;
            }
            while (i < v2.Length && final == 0)
            {
                int res = Convert.ToInt32(v2[i++]);
                if (res >= 1)
                    return --final;
            }
            return final;
        }
    }
}
