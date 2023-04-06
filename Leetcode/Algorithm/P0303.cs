/*
 * Author: Deean
 * Date: 2023-04-06 23:21:03
 * FileName: P0303.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0303 {
    public class NumArray {
        private int[] acc;

        public NumArray(int[] nums) {
            acc = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
                acc[i] = sum;
            }
        }

        public int SumRange(int left, int right) {
            return left == 0 ? acc[right] : acc[right] - acc[left - 1];
        }
    }

    public static void Test() {
        NumArray obj = new NumArray(new[] { -2, 0, 3, -5, 2, -1 });
        Console.WriteLine(obj.SumRange(0, 2));
        Console.WriteLine(obj.SumRange(2, 5));
        Console.WriteLine(obj.SumRange(0, 5));
    }
}