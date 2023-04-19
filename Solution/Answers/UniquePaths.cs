using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class UniquePaths
    {
        public static void Run()
        {
            Console.WriteLine("m = 3 n = 2   : " + Solution3(3, 2));
            Console.WriteLine("m = 7 n = 3   : " + Solution3(7, 3));
            Console.WriteLine("m = 3 n = 7   : " + Solution3(3, 7));
            Console.WriteLine("m = 23 n = 12 : " + Solution3(23, 12));
        }
        public static int Solution(int m, int n)
        {
            int[,] matrix = new int[m, n];
            matrix[0, 0] = 1;

            for (int i = 1; i < m; i++)
                matrix[i, 0] = 1;

            for (int i = 1; i < n; i++)
                matrix[0, i] = 1;

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];

            return matrix[m - 1, n - 1];
        }

        public static int Solution2(int m, int n)
        {
            double uniquePaths = 1;

            for (int i = 1; i <= Math.Min(m - 1, n - 1); i++)
            {
                uniquePaths *= (double)(m + n - 2 - i + 1) / i;
            }

            return (int)Math.Round(uniquePaths);
        }

        public static double Solution3(int m, int n)
        {
            return SpecialFunctions.Factorial(m + n - 2) / (SpecialFunctions.Factorial(m - 1) * SpecialFunctions.Factorial(n - 1));
        }
    }
}
