using System;
using System.Collections.Generic;
using System.Text;

namespace RotatedSortedArrayCSharp
{
    /// <summary>
    /// Debuggingtest
    /// </summary>
    public static class DebuggingTests
    {
        /// <summary>
        /// Test1
        /// </summary>
        public static void Test1()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            Search(nums, target);
        }

        /// <summary>
        /// Test2
        /// </summary>
        public static void Test2()
        {
            int[] nums = { 3, 1 };
            int target = 1;
            Search(nums, target);
        }

        /// <summary>
        /// Debuggins tests search
        /// </summary>
        /// <param name="nums">Nums</param>
        /// <param name="target">Target</param>
        private static void Search(int[] nums, int target)
        {
            Solution solution = new Solution();
            var result = solution.Search(nums, target);

            Console.WriteLine(string.Join(',', nums));
            Console.WriteLine("Index of {0} is {1}", target, result);
        }
    }
}
