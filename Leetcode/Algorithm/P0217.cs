/*
 * Author: Deean
 * Date: 2023-04-07 22:53:47
 * FileName: P0217.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0217 {
    public class Solution {
        public bool ContainsDuplicate(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums) {
                if (set.Contains(num)) {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ContainsDuplicate(new[] { 1, 2, 3, 1 });
        Console.WriteLine(ans);
    }
}