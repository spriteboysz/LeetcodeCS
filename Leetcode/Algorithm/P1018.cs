/*
 * Author: Deean
 * Date: 2023-04-02 15:44:15
 * FileName: P1018.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1018 {
    public class Solution {
        public IList<bool> PrefixesDivBy5(int[] nums) {
            IList<bool> prefix = new List<bool>();
            int sum = 0;
            foreach (var num in nums) {
                sum = (sum * 2 + num) % 10;
                prefix.Add(sum is 0 or 5);
            }
            return prefix.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PrefixesDivBy5(new[] { 0, 1, 1 });
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}