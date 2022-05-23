using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class PlusOne
    {
        public static void Run()
        {
            var nums = new int[] { 1, 2, 3 };
            //var nums = new int[] { 4, 3, 2, 1 };
            //var nums = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //var nums = new int[] { 9 };
            //var nums = new int[] { 8, 9, 9, 9 };
            var response = Solution(nums);
        }
        public static int[] Solution(int[] digits)
        {
            List<int> newDigitis = new List<int>();

            bool IsCarry = digits[digits.Length - 1] == 9;

            for (int i = digits.Length - 1; i > -1; i--)
            {
                if (IsCarry)
                {
                    IsCarry = digits[i] == 9;

                    newDigitis.Add((digits[i] + 1) % 10);

                    if (i == 0 && IsCarry)
                        newDigitis.Add((digits[i] + 1) / 10);
                }
                else
                {
                    if (i == digits.Length - 1)
                        newDigitis.Add(digits[i] + 1);
                    else
                        newDigitis.Add(digits[i]);
                }
            }

            newDigitis.Reverse();
            return newDigitis.ToArray();
        }
    }
}

