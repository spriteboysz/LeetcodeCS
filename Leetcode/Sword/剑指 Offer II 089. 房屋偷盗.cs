/*
 * Author: Deean
 * Date: 2023-05-30 23:28:00
 * FileName: 剑指 Offer II 089. 房屋偷盗.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_II_089__房屋偷盗 {
    public class Solution {
        public int Rob(int[] nums) {
            int n = nums.Length;
            if (n == 1) return nums[0];
            int[] dp = new int[n];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; i++) {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            return dp[n - 1];
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Rob(new[] { 1, 2, 3, 1 });
        Console.WriteLine(ans);
    }
}