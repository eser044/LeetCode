using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    internal class LongestPalindromicSubstring
    {
        public static void Run()
        {
            var input = "babad";
            var response = Solution(input);
        }
        public static string Solution(string s)
        {
            // Get length of input string
            int n = s.Length;

            // Table[i, j] will be false if substring
            // str[i..j] is not palindrome. Else
            // table[i, j] will be true
            bool[,] table = new bool[n, n];

            // All substrings of length 1 are palindromes
            int maxLength = 1;
            for (int i = 0; i < n; ++i)
                table[i, i] = true;

            // Check for sub-string of length 2.
            int start = 0;

            for (int i = 0; i < n - 1; ++i)
            {
                if (s[i] == s[i + 1])
                {
                    table[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for lengths greater than 2.
            // k is length of substring
            for (int k = 3; k <= n; ++k)
            {

                // Fix the starting index
                for (int i = 0; i < n - k + 1; ++i)
                {

                    // Get the ending index of substring from
                    // starting index i and length k
                    int j = i + k - 1;

                    // Checking for sub-string from ith index
                    // to jth index iff str.charAt(i+1) to
                    // str.charAt(j-1) is a palindrome
                    if (table[i + 1, j - 1] && s[i] == s[j])
                    {
                        table[i, j] = true;
                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
            return s.Substring(start, maxLength);
        }
    }
}
