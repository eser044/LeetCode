using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static void Run()
        {
            var nums = new int[] { 1, 1, 2 };
            //var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var response = Solution(nums);
        }
        public static int Solution(int[] nums)
        {
            if (nums == null) return 0;
            var temp = nums.Distinct().ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < temp.Length)
                    nums[i] = temp[i];
                else
                    nums[i] = 0;
            }
            return temp.Length;
        }
    }
}
