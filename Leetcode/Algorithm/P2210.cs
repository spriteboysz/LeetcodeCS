/*
 * Author: Deean
 * Date: 2023-03-22 22:31:45
 * FileName: P2210.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2210 {
    public class Solution {
        public int CountHillValley(int[] nums) {
            int cnt = 0;
            for (int i = 1; i < nums.Length - 1; i++) {
                int left = i - 1, right = i + 1;
                while (left != 0 && nums[i] == nums[left]) {
                    left--;
                    i++;
                }
                while (right != nums.Length - 1 && nums[i] == nums[right]) {
                    right++;
                    i++;
                }
                if ((nums[i] > nums[left] && nums[i] > nums[right]) ||
                    (nums[i] < nums[left] && nums[i] < nums[right])) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountHillValley(new[] { 2, 4, 1, 1, 6, 5 });
        Console.WriteLine(ans);
    }
}