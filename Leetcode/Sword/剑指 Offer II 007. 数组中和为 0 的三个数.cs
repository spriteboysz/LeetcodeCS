/*
 * Author: Deean
 * Date: 2023-05-21 11:07:11
 * FileName: 剑指 Offer II 007. 数组中和为 0 的三个数.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_007__数组中和为_0_的三个数 {
    public class Solution {
        public IList<IList<int>> ThreeSum(int[] nums) {
            Array.Sort(nums);
            IList<IList<int>> three = new List<IList<int>>();
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (i > 0 && nums[i - 1] == nums[i]) continue;
                int left = i + 1, right = n - 1;
                while (left < right) {
                    var sum = nums[left] + nums[right] + nums[i];
                    if (sum == 0) {
                        three.Add(new List<int> { nums[left], nums[right], nums[i] });
                        while (left + 1 < right && nums[left] == nums[left + 1]) left++;
                        left++;
                    } else if (sum < 0) {
                        left++;
                    } else {
                        right--;
                    }
                }
            }
            return three;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
        Console.WriteLine(ans);
    }
}