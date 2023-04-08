/*
 * Author: Deean
 * Date: 2023-04-08 20:14:08
 * FileName: 面试题 01.02. 判定是否互为字符重排.cs
 * Description:
*/

using System;
using System.Linq;

namespace Interview; 

public class 面试题_01_02__判定是否互为字符重排 {
    public class Solution {
        public bool CheckPermutation(string s1, string s2) {
            int[] hash = new int[26];
            foreach (var c in s1) {
                hash[c - 'a']++;
            }
            foreach (var c in s2) {
                hash[c - 'a']--;
            }
            return hash.All(num => num == 0);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckPermutation("abc", "bca");
        Console.WriteLine(ans);
    }
}