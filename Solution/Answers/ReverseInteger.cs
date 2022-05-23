using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ReverseInteger
    {
        public static void Run()
        {
            //var nums = 321;
            var nums = -2147483648;
            var response = Solution(nums);
        }
        public static int Solution(int x)
        {
            int response = 0;
            bool isMinus = x < 0;
            string reversedNumStr = string.Join(null, x.ToString().ToCharArray().Where(x => x != '-').Select(c => c.ToString()).ToArray().Reverse());
            reversedNumStr = isMinus ? "-" + reversedNumStr : reversedNumStr;
            int.TryParse(reversedNumStr, out response);
            return response;
        }
    }
}