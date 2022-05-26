using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Model
{
    public class Hint
    {
        public int[] Numbers { get; }
        public int CorrectCount { get; }
        public bool CorrectPlace { get; }

        public Hint(int[] numbers, int correctCount, bool correctPlace)
        {
            Numbers = numbers;
            CorrectCount = correctCount;
            CorrectPlace = correctPlace;
        }
    }
}
