/*
 * Author: Deean
 * Date: 2023-03-23 23:40:42
 * FileName: P1913.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1913 {
    public class Solution {
        public int MaxProductDifference(int[] nums) {
            int max1 = Int32.MinValue, max2 = Int32.MinValue;
            int min1 = Int32.MaxValue, min2 = Int32.MaxValue;
            foreach (var num in nums) {
                if (num > max1) {
                    max2 = max1;
                    max1 = num;
                } else if (num > max2) {
                    max2 = num;
                }
                if (num < min1) {
                    min2 = min1;
                    min1 = num;
                } else if (num < min2) {
                    min2 = num;
                }
            }
            return max1 * max2 - min1 * min2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxProductDifference(new[] { 4, 2, 5, 9, 7, 4, 8 });
        Console.WriteLine(ans);
    }
}