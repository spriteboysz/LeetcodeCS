/*
 * Author: Deean
 * Date: 2023-03-26 23:31:21
 * FileName: P1460.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P1460 {
    public class Solution {
        public bool CanBeEqual(int[] target, int[] arr) {
            int[] hash = new int[1001];
            foreach (var num in target) {
                hash[num]++;
            }
            foreach (var num in arr) {
                hash[num]--;
            }
            return hash.All(num => num == 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanBeEqual(new[] { 1, 2, 3, 4 }, new[] { 2, 4, 1, 3 });
        Console.WriteLine(ans);
    }
}