using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class PalindromeNumber
    {
        public static void Run()
        {
            //var nums = 245383542;
            //var nums = -245383542;
            var nums = -121;

            var response = Solution(nums);
        }
        public static bool Solution(int x)
        {
            if (x < 0) return false;
            if (x > -1 && x < 10) return true;
            
            string xString = x.ToString();

            bool isLenghtEvenNumber = x.ToString().Length % 2 == 0;

            if (isLenghtEvenNumber)
            {
                for (int i = 0; i < xString.Length / 2; i++)
                    if (xString[i] != xString[xString.Length - 1 - i])
                        return false;
            }
            else
            {
                for (int i = 0; i < (xString.Length - 1) / 2; i++)
                    if (xString[i] != xString[xString.Length - 1 - i])
                        return false;
            }

            return true;
        }
    }
}
