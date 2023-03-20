/*
 * Author: Deean
 * Date: 2023-03-19 23:08:37
 * FileName: P2099.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2099 {
    public class Solution {
        public int[] MaxSubsequence(int[] nums, int k) {
            int n = nums.Length;
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++) {
                arr[i] = new[] { i, nums[i] };
            }
            Array.Sort(arr, (a, b) => b[1] - a[1]);

            int[] index = new int[k];
            for (int i = 0; i < k; i++) {
                index[i] = arr[i][0];
            }
            Array.Sort(index);

            int[] res = new int[k];
            for (int i = 0; i < k; i++) {
                res[i] = nums[index[i]];
            }
            return res;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxSubsequence(new[] { 2, 1, 3, 3 }, 2);
        Console.WriteLine(ans);
    }
}