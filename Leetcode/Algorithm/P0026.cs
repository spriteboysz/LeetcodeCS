/*
 * Author: Deean
 * Date: 2023-04-08 11:24:23
 * FileName: P0026.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0026 {
    public class Solution {
        public int RemoveDuplicates(int[] nums) {
            int n = nums.Length;
            if (n == 0) return 0;
            int slow = 0, fast = 1;
            while (fast < n) {
                if (nums[fast] != nums[slow]) {
                    nums[++slow] = nums[fast];
                }
                fast++;
            }
            return slow + 1;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveDuplicates(new[]{1,1,2});
        Console.WriteLine(ans);
    }
}