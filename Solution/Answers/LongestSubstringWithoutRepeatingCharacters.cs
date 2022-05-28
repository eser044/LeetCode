using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static void Run()
        {
            //var input = "abcabcbb";
            //var input = "pwwkew";
            //var input = "au";
            var input = "dvdf";

            var result = Solution(input);
        }
        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            if (s.Length == 1)
                return 1;

            string longest = string.Empty;
            string tmp = string.Empty;

            tmp += s[0].ToString();

            int indexOf;
            for (int i = 1; i < s.Length; i++)
            {
                indexOf = tmp.IndexOf(s[i].ToString());
                if (indexOf < 0)
                {
                    tmp += s[i];
                }
                else
                {
                    if (tmp.Length > longest.Length)
                        longest = tmp;

                    tmp = tmp.Substring(indexOf + 1) + s[i].ToString();
                }
            }

            if (tmp.Length > longest.Length)
                longest = tmp;

            return longest.Length;
        }
    }
}
