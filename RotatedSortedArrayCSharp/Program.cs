using System;

namespace RotatedSortedArrayCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DebuggingTests.Test2();
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Solution
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="nums">Nums </param>
        /// <param name="target">Target</param>
        /// <returns>Index</returns>
        public int Search(int[] nums, int target)
        {
            if (nums.Length > 0)
            {
                return SearchInRotatedArray(nums, target, 0, nums.Length - 1);
            }

            return -1;
        }

        /// <summary>
        /// Search in rotated array
        /// </summary>
        /// <param name="nums">Nums</param>
        /// <param name="target">Target</param>
        /// <param name="start">Start</param>
        /// <param name="end">End</param>
        /// <returns>Index</returns>
        private int SearchInRotatedArray(int[] nums, int target, int start, int end)
        {
            int middle = (start + end)/2;

            if (nums[middle] == target)
            {
                return middle;
            }

            if (end <= start)
            {
                return -1;
            }

            //Left side is sorted
            if(nums[start] <= nums[middle])
            {
                if(nums[start] <= target && target < nums[middle])
                {
                    return SearchInRotatedArray(nums, target, start, middle - 1);
                }
                else
                {
                    return SearchInRotatedArray(nums, target, middle + 1, end);
                }
            }
            else //nums[middle] < nums[end] Right side is sorted
            {
                if(nums[middle] < target && target <= nums[end])
                {
                    return SearchInRotatedArray(nums, target, middle + 1, end);
                }
                else //target is on the left side
                {
                    return SearchInRotatedArray(nums, target, start, middle - 1);
                }
            }
        }
    }
}
