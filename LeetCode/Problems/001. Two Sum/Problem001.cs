using System;

namespace Problems._001._Two_Sum
{
    public class Problem001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            foreach (var num in nums)
            {
                foreach (var i in nums)
                {
                    if (num + i == target)
                    {
                        return new int[] { Array.IndexOf(nums, num), Array.IndexOf(nums, i) };
                    }
                }
            }
            return new int[]{};
        }
    }
}