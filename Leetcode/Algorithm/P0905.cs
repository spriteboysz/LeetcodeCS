/*
 * Author: Deean
 * Date: 2023-04-03 22:52:59
 * FileName: P0905.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0905 {
    public class Solution {
        public int[] SortArrayByParity(int[] nums) {
            IList<int> even = new List<int>(), odd = new List<int>();
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    even.Add(num);
                } else {
                    odd.Add(num);
                }
            }
            return even.Concat(odd).ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortArrayByParity(new[] { 3, 1, 2, 4 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}