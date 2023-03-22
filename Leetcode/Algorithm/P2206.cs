/*
 * Author: Deean
 * Date: 2023-03-22 22:27:29
 * FileName: P2206.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2206 {
    public class Solution {
        public bool DivideArray(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums) {
                if (dict.ContainsKey(num)) {
                    dict[num] += 1;
                } else {
                    dict.Add(num, 1);
                }
            }
            return dict.All(pair => pair.Value % 2 == 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DivideArray(new[] { 3, 2, 3, 2, 2, 2 });
        Console.WriteLine(ans);
    }
}