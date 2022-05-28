using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class IntegerToRoman
    {
        public static void Run()
        {
            var input = 75394;
            var result = Solution(input);
        }

        public static string Solution(int num)
        {
            var result = new StringBuilder();
            var values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    result.Append(symbols[i]);
                    num -= values[i];
                }
            }
            return result.ToString();
        }
    }
}
