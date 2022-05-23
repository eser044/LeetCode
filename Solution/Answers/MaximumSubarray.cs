using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class MaximumSubarray
    {
        public static void Run()
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var respınse = Solution(nums);
        }
        public static int Solution(int[] nums)
        {
            int sum = 0;
            int maxi = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > maxi) maxi = sum;
                if (sum < 0) sum = 0;
            }

            return maxi;
        }
    }
}
