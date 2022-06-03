using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class StringtoIntegerAtoi
    {
        public static void Run()
        {
            //var input = "42";
            //var input = "   -42";
            //var input = "4193 with words";
            //var input = "with 4193 words";
            //var input = "-91283472332";
            //var input = "-2147483647";
            var input = "-2147483649";

            var result = Solution(input);
        }


        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var result = 0;
            var isNegative = false;
            var isFirst = true;

            foreach (var c in s)
            {
                if (isFirst && c == ' ')
                    continue;

                if (isFirst && c == '-')
                {
                    isFirst = false;
                    isNegative = true;
                    continue;
                }

                if (isFirst && c == '+')
                {
                    isFirst = false;
                    isNegative = false;
                    continue;
                }

                if (c < '0' || c > '9')
                    break;
                else
                    isFirst = false;

                if (isNegative)
                {
                    if (result < int.MinValue / 10 || (result == int.MinValue / 10 && (-1 * (c - '0')) < int.MinValue % 10))
                        return int.MinValue;

                    result = result * 10 - (c - '0');
                }
                else
                {
                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && c - '0' > int.MaxValue % 10))
                        return int.MaxValue;

                    result = result * 10 + (c - '0');
                }
            }

            return result;
        }
    }
}
