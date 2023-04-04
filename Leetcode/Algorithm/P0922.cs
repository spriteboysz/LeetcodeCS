/*
 * Author: Deean
 * Date: 2023-04-03 23:20:22
 * FileName: P0922.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0922 {
    public class Solution {
        public int[] SortArrayByParityII(int[] nums) {
            IList<int> even = new List<int>(), odd = new List<int>();
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    even.Add(num);
                } else {
                    odd.Add(num);
                }
            }
            for (int i = 0, pos1 = 0, pos2 = 0; i < nums.Length; i++) {
                if (i % 2 == 0) {
                    nums[i] = even[pos1++];
                } else {
                    nums[i] = odd[pos2++];
                }
            }
            return nums;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortArrayByParityII(new[] { 4, 2, 5, 7 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}