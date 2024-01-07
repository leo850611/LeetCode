using System;
using System.Collections;
using System.Collections.Generic;

namespace Problems._001._Two_Sum
{
    // https://leetcode.com/problems/two-sum/
    public class Problem001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hashtable = new Hashtable();
            
            for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
            {
                var currentNum = nums[currentIndex];
                var searchNum = target - currentNum;
                if (hashtable.Contains(searchNum))
                {
                    if (currentIndex != (int) hashtable[searchNum])
                    {
                        return new int[] { (int) hashtable[searchNum], currentIndex };
                    }
                }
                else
                {
                    hashtable[currentNum] = currentIndex;
                }
            }
            
            return new int[] { };
        }

        public int[] TwoSum_hashSet(int[] nums, int target)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!hashSet.TryGetValue(num, out var value))
                {
                    hashSet.Add(num);
                }
            }

            for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
            {
                var searchNum = target - nums[currentIndex];
                if (hashSet.TryGetValue(searchNum, out var searchResult))
                {
                    var indexOfSearchResult = Array.IndexOf(nums, searchResult, currentIndex + 1);
                    if (indexOfSearchResult >=0 && currentIndex != indexOfSearchResult)
                    {
                        return new int[] { currentIndex, indexOfSearchResult };
                    }
                }
            }
            
            return new int[] { };
        }
        
        public int[] TwoSum_for(int[] nums, int target)
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