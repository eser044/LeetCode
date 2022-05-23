using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ValidParentheses
    {
        public static void Run()
        {
            //var input = "()[]{}";
            //var input = "{[]}";
            var input = "([}}])";
            var respoınse = Solution(input);
        }
        public static bool Solution(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1 || s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            foreach (var item in s)
            {
                bool isAynAction = false;
                if (item == '(' || item == '[' || item == '{')
                {
                    isAynAction = true;
                    stack.Push(item);
                }
                
                if (item == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    isAynAction |= true;
                    stack.Pop();
                }
                
                if (item == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    isAynAction |= true;
                    stack.Pop();
                }

                if (item == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    isAynAction |= true;
                    stack.Pop();
                }

                if (!isAynAction)
                    return isAynAction;
            }

            return (stack.Count == 0);
        }

    }
}
