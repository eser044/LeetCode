using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    internal class LongestCommonPrefix
    {
        public static void Run()
        {
            //var strArray = new string[] { "dog", "racecar", "car" };
            var strArray = new string[] { "flower", "flow", "flight" };

            var response = Solution(strArray);
        }
        public static string Solution(string[] strs)
        {
            if (strs == null || strs.Length < 1) return string.Empty;
            
            string response = string.Empty;
            List<string> strslist = strs.ToList().OrderBy(x => x.Length).ToList();

            for (int i = 0; i < strslist[0].Length; i++)
            {
                bool isChrExist = true;
                foreach (var item in strslist)
                {
                    if (strslist[0][i] != item[i])
                    {
                        isChrExist = false;
                        break;
                    }
                }

                if (isChrExist)
                    response += strslist[0][i];
                else
                    response += "-";
            }

            return response.Split(new char[] { '-' }).ToList()[0];
        }
    }
}
