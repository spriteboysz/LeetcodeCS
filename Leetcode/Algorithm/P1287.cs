/*
 * Author: Deean
 * Date: 2023-03-31 22:40:54
 * FileName: P1287.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1287 {
    public class Solution {
        public int FindSpecialInteger(int[] arr) {
            int n = arr.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in arr) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
                if (dict[num] > n * 0.25) {
                    return num;
                }
            }
            return -1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindSpecialInteger(new[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 });
        Console.WriteLine(ans);
    }
}