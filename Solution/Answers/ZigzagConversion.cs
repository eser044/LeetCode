using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ZigzagConversion
    {
        public static void Run()
        {
            var input = "PAYPALISHIRING";
            var numRows = 3;
            var result = Solution(input, numRows);
        }

        public static string Solution(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            var result = new StringBuilder();
            var step = 2 * numRows - 2;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j + i < s.Length; j += step)
                {
                    result.Append(s[j + i]);
                    if (i != 0 && i != numRows - 1 && j + step - i < s.Length)
                        result.Append(s[j + step - i]);
                }
            }

            return result.ToString();
        }
    }
}
