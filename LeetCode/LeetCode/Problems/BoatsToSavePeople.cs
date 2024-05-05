using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class BoatsToSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            int length = people.Length;
            if (length <= 1)
                return 1;
            if (length == 2)
            {
                if (people[0] + people[1] <= limit)
                    return 1;
                else
                    return 2;
            }

            Array.Sort(people);
            int res = 0, right = length - 1, left = 0;

            while (left <= right)
            {
                if (people[left] + people[right] <= limit)
                    left++;

                right--;
                res++;
            }

            return res;
        }
    }
}
