using System;

namespace Problems._001._Two_Sum
{
    public class Problem001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var currentIndex = 0;
            foreach (var num in nums)
            {
                foreach (var i in nums)
                {
                    if (num + i == target)
                    {
                        var firstOfIndex = Array.IndexOf(nums, num);
                        var secondOfIndex = Array.IndexOf(nums, i, currentIndex + 1);
                        if (firstOfIndex >= 0 && secondOfIndex >= 0 && firstOfIndex != secondOfIndex)
                        {
                            return new[] { firstOfIndex, secondOfIndex }; 
                        }
                    }
                }

                currentIndex++;
            }

            return new int[] { };
        }
    }
}