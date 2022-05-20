using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class TwoSum
    {
        public static void Run()
        {
            var nums = new int[] { 2,7,11,15};

            var response = Solution(nums, 9);
        }
        public static int[] Solution(int[] nums, int target)
        {
            var response = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i != j) && (nums[i] + nums[j] == target))
                    {
                        response[0] = i;
                        response[1] = j;
                        return response; ;
                    }
                }
            }

            return response;
        }
    }
}
