/*
 * Author: Deean
 * Date: 2023-04-08 20:22:20
 * FileName: 面试题 01.04. 回文排列.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview;

public class 面试题_01_04__回文排列 {
    public class Solution {
        public bool CanPermutePalindrome(string s) {
            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in s) {
                if (!dict.ContainsKey(c)) {
                    dict.Add(c, 0);
                }
                dict[c]++;
            }
            return dict.Values.Count(num => num % 2 == 1) <= 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanPermutePalindrome("tactcoa");
        Console.WriteLine(ans);
    }
}