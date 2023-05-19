/*
 * Author: Deean
 * Date: 2023-05-19 21:56:01
 * FileName: P2679.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2679 {
    public class Solution {
        public int MatrixSum(int[][] nums) {
            foreach (var row in nums) {
                Array.Sort(row);
            }
            int sum = 0;
            for (int j = 0; j < nums[0].Length; j++) {
                int maximum = 0;
                for (int i = 0; i < nums.Length; i++) {
                    maximum = Math.Max(maximum, nums[i][j]);
                }
                sum += maximum;
            }
            return sum;
        }
    }

    public static void Test() {
        int[][] nums = Arrays.To2DArray("[[7,2,1],[6,4,2],[6,5,3],[1,2,3]]");
        var s = new Solution();
        var ans = s.MatrixSum(nums);
        Console.WriteLine(ans);
    }
}