/*
 * Author: Deean
 * Date: 2023-04-04 12:34:08
 * FileName: P0724.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P0724 {
    public class Solution {
        public int PivotIndex(int[] nums) {
            int acc = 0, sum = nums.Sum();
            for (int i = 0; i < nums.Length; i++) {
                if (2 * acc + nums[i] == sum) {
                    return i;
                }
                acc += nums[i];
            }
            return -1;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PivotIndex(new []{1, 7, 3, 6, 5, 6});
        Console.WriteLine(ans);
    }
}