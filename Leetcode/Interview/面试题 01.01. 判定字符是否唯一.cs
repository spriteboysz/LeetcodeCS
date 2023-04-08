/*
 * Author: Deean
 * Date: 2023-04-08 20:11:26
 * FileName: 面试题 01.01. 判定字符是否唯一.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Interview; 

public class 面试题_01_01__判定字符是否唯一 {
    public class Solution {
        public bool IsUnique(string astr) {
            HashSet<char> set = new HashSet<char>();
            foreach (var c in astr) {
                if (set.Contains(c)) {
                    return false;
                }
                set.Add(c);
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsUnique("leetcode");
        Console.WriteLine(ans);
    }
}