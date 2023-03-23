/*
 * Author: Deean
 * Date: 2023-03-23 23:45:31
 * FileName: P1909.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1909 {
    public class Solution {
        private bool check(List<int> list) {
            for (int i = 1; i < list.Count; i++) {
                if (list[i - 1] >= list[i]) {
                    return false;
                }
            }
            return true;
        }

        public bool CanBeIncreasing(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                List<int> list = new List<int>(nums);
                list.RemoveAt(i);
                if (check(list)) {
                    return true;
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanBeIncreasing(new[] { 1, 2, 10, 5, 7 });
        Console.WriteLine(ans);
    }
}