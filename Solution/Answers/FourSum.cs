namespace Solution.Answers
{
    public class FourSum
    {
        public static void Run()
        {
            var input = new int[] { 1, 0, -1, 0, -2, 2 };
            var response = Solution(input, 0);

            //Sum is Over to in maxValue, you have to check it
            //var input = new int[] { 1000000000, 1000000000, 1000000000, 1000000000 };
            //var response = Solution(input, -294967296);
        }

        public static IList<IList<int>> Solution(int[] nums, int target)
        {
            IList<IList<int>> responseList = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    for (int j = i + 1; j < nums.Length - 2; j++)
                    {
                        if (j == i + 1 || nums[j] != nums[j - 1])
                        {
                            int left = j + 1;
                            int right = nums.Length - 1;
                            while (left < right)
                            {
                                var result = SumAndCheckOverFlow(nums[i], nums[j], nums[right], nums[left]);
                                if (!result.isOverFlow && result.Sum == target)
                                {
                                    responseList.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                                    while (left < right && nums[right] == nums[right - 1])
                                        right--;

                                    while (left < right && nums[left] == nums[left + 1])
                                        left++;

                                    left++;
                                    right--;
                                }
                                else if (result.Sum < target)
                                    left++;
                                else
                                    right--;
                            }
                        }
                    }
                }
            }

            return responseList;
        }

        public static (bool isOverFlow, int Sum) SumAndCheckOverFlow(params int[] numbers)
        {
            try
            {
                checked
                {
                    int result = 0;
                    foreach (var item in numbers)
                        result += item;

                    return (false, result);
                }
            }
            catch (OverflowException)
            {
                return (true, 0);
            }
        }
    }
}
