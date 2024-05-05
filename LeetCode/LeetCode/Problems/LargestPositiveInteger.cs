using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class LargestPositiveInteger
    {
        /// <summary>
        /// Example 1:
        /// Input: nums = [-1,2,-3,3]
        /// Output: 3
        /// Explanation: 3 is the only valid k we can find in the array.
        /// 
        /// Example 2:
        /// Input: nums = [-1, 10, 6, 7, -7, 1]
        /// Output: 7
        /// Explanation: Both 1 and 7 have their corresponding negative values in the array. 7 has a larger value.
        /// 
        /// Example 3:
        /// Input: nums = [-10, 8, 6, 7, -2, -3]
        /// Output: -1
        /// Explanation: There is no a single valid k, we return -1.
        /// 
        /// Constraints:
        /// 1 <= nums.length <= 1000
        /// -1000 <= nums[i] <= 1000
        /// nums[i] != 0
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxK(int[] nums)
        {
            int max = -1, length = nums.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[i] + nums[j] == 0)
                    {
                        int res = Math.Abs(nums[i]);
                        if (max < res)
                            max = res;
                    }
                }
            }
            return max;
        }
    }
}
