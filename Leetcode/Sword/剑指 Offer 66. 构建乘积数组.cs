/*
 * Author: Deean
 * Date: 2023-05-21 10:38:05
 * FileName: 剑指 Offer 66. 构建乘积数组.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_66__构建乘积数组 {
    public class Solution {
        public int[] ConstructArr(int[] nums) {
            int n = nums.Length;
            if (n == 0) return new int[0];
            int[] left = new int[n], right = new int[n], arr = new int[n];
            left[0] = 1;
            for (int i = 1; i < n; i++) {
                left[i] = left[i - 1] * nums[i - 1];
            }
            right[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--) {
                right[i] = right[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < n; i++) {
                arr[i] = left[i] * right[i];
            }
            return arr;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConstructArr(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine(Arrays.ToString(ans));
    }
}