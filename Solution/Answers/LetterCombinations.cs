using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class LetterCombinations
    {
        public static void Run()
        {
            var input = "235";
            //var input = "";
            Solution(input);
        }

        public static IList<string> Solution(string digits)
        {
            List<string> result = new List<string>();

            if (string.IsNullOrEmpty(digits) || !digits.All(char.IsNumber))
                return result;

            int[] numbers = digits.Select(n => Convert.ToInt32(n.ToString())).ToArray();

            return Combinations(numbers, digits.Length);
        }
        private static List<String> Combinations(int[] number, int n)
        {
            String[] table = { "0",   "1",   "abc",  "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            return letterCombinationsUtil(number, n, table);
        }

        private static List<String> letterCombinationsUtil(int[] number, int n, String[] table)
        {
            List<String> list = new List<String>();

            Queue<String> q = new Queue<String>();
            q.Enqueue("");

            while (q.Count != 0)
            {
                String s = q.Dequeue();
                if (s.Length == n)
                    list.Add(s);
                else
                {
                    String val = table[number[s.Length]];
                    for (int i = 0; i < val.Length; i++)
                    {
                        q.Enqueue(s + val[i]);
                    }
                }
            }
            return list;
        }
    }
}
