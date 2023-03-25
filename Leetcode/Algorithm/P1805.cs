/*
 * Author: Deean
 * Date: 2023-03-24 23:08:55
 * FileName: P1805.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Algorithm;

public class P1805 {
    public class Solution {
        public int NumDifferentIntegers(string word) {
            string[] nums = Regex.Split(word, "\\D");
            // Console.WriteLine(lib.Arrays.ToString(nums));
            HashSet<string> set = new HashSet<string>();
            foreach (var num in nums) {
                if (num.Length > 0) {
                    set.Add(num.TrimStart('0'));
                }
            }
            return set.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumDifferentIntegers("a1b01cd001");
        Console.WriteLine(ans);
    }
}