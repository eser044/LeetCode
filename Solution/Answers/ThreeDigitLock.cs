using Solution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class ThreeDigitLock
    {
        public static void Run()
        {
            var response = Solution();
        }
        public static string Solution()
        {
            var possibilities = new List<List<int>>
            {
                new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };

            var hints = new List<Hint>
            {
                new Hint{Numbers = new[] {6, 9, 0}, CorrectNumberCount =  1, CorrectNumberPlace = true},
                new Hint{Numbers = new[] {7, 4, 1}, CorrectNumberCount =  1, CorrectNumberPlace = false},
                new Hint{Numbers = new[] {5, 0, 4}, CorrectNumberCount =  2, CorrectNumberPlace = false},
                new Hint{Numbers = new[] {3, 8, 7}, CorrectNumberCount =  0, CorrectNumberPlace = false},
                new Hint{Numbers = new[] {2, 1, 9}, CorrectNumberCount =  1, CorrectNumberPlace = false}
            };

            foreach (var hint in hints)
            {
                if (hint.CorrectNumberCount == 0)
                {
                    foreach (var possibility in possibilities)
                    {
                        possibility.RemoveAll(i => hint.Numbers.Any(j => i == j));
                    }
                }
                else if (!hint.CorrectNumberPlace)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        possibilities[i].Remove(hint.Numbers[i]);
                    }
                }
            }

            var combinations = new List<int[]>();
            for (var i = 0; i < possibilities[0].Count; i++)
            {
                for (var j = 0; j < possibilities[1].Count; j++)
                {
                    for (var k = 0; k < possibilities[2].Count; k++)
                    {
                        var combination = new[] { possibilities[0][i], possibilities[1][j], possibilities[2][k] };
                        var fits = true;
                        foreach (var hint in hints)
                        {
                            var matches = combination.Intersect(hint.Numbers).ToList();
                            if (matches.Count != hint.CorrectNumberCount)
                            {
                                fits = false;
                                continue;
                            }

                            foreach (var match in matches)
                            {
                                var placeCondition = Array.FindIndex(combination, val => val == match) == Array.FindIndex(hint.Numbers, val => val == match);
                                if (placeCondition != hint.CorrectNumberPlace)
                                {
                                    fits = false;
                                    break;
                                }
                            }
                        }

                        if (fits) combinations.Add(combination);
                    }
                }
            }

            return string.Join('-', combinations.Select(i => string.Join(null, i)));
        }
    }
}
