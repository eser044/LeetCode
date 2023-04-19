using BenchmarkDotNet.Attributes;
using Solution.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Banchmarks
{
    [MemoryDiagnoser]
    public class UniquePathsBanchmarks
    {
        [Benchmark]
        public void UniquePathsSolution1()
        {
            UniquePaths.Solution(3, 2);
            UniquePaths.Solution(7, 3);
            UniquePaths.Solution(3, 7);
            UniquePaths.Solution(23, 12);
        }

        [Benchmark]
        public void UniquePathsSolution2()
        {
            UniquePaths.Solution2(3, 2);
            UniquePaths.Solution2(7, 3);
            UniquePaths.Solution2(3, 7);
            UniquePaths.Solution2(23, 12);
        }

        [Benchmark]
        public void UniquePathsSolution3()
        {
            UniquePaths.Solution3(3, 2);
            UniquePaths.Solution3(7, 3);
            UniquePaths.Solution3(3, 7);
            UniquePaths.Solution3(23, 12);
        }
    }
}
