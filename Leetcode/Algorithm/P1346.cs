/*
 * Author: Deean
 * Date: 2023-03-30 23:41:13
 * FileName: P1346.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P1346 {
    public class Solution {
        public bool CheckIfExist(int[] arr) {
            Array.Sort(arr, (a, b) => Math.Abs(b) - Math.Abs(a));
            HashSet<int> set = new HashSet<int>();
            foreach (var num in arr) {
                if (set.Contains(num * 2)) {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckIfExist(new[] { 10, 2, 5, 3 });
        Console.WriteLine(ans);
    }
}