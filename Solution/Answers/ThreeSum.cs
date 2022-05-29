using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ThreeSum
    {
        public static void Run()
        {
            var input = new int[] { -1, 0, 1, 2, -1, -4 };
            var response = Solution(input);
        }

        public static IList<IList<int>> Solution(int[] nums)
        {
            IList<IList<int>> responseList = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int left = i + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[right] + nums[left];
                        if (sum == 0)
                        {
                            responseList.Add(new List<int> { nums[i], nums[left], nums[right] });

                            while (left < right && nums[right] == nums[right - 1]) 
                                right--;
                            
                            while (left < right && nums[left] == nums[left + 1]) 
                                left++;

                            left++;
                            right--;
                        }
                        else if (sum < 0)
                            left++;
                        else
                            right--;
                    }
                }
            }

            return responseList;
        }
    }
}
