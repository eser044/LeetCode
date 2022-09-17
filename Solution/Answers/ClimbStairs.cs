using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ClimbStairs
    {
        public static void Run()
        {
            var input = 3;
            //var input = 0;
            Solution(input);
        }

        public static int Solution(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
