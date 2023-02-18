using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    internal class GenerateParenthesis
    {
        public static void Run()
        {
            var result = Solution(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<string> Solution(int n)
        {
            var result = new List<string>();
            GenerateParenthesisHelper(result, "", n, n);
            return result;
        }

        private static void GenerateParenthesisHelper(List<string> result, string current, int left, int right)
        {
            if (left == 0 && right == 0)
            {
                result.Add(current);
                return;
            }

            if (left > 0)
                GenerateParenthesisHelper(result, current + "(", left - 1, right);

            if (right > left)
                GenerateParenthesisHelper(result, current + ")", left, right - 1);
        }
    }
}
