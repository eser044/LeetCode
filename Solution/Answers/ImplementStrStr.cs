using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ImplementStrStr
    {
        public static void Run()
        {
            var haystack = "aaaaa";
            var needle = "bba";
            var response = Solution(haystack, needle);
        }
        public static int Solution(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
