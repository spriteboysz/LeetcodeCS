/*
 * Author: Deean
 * Date: 2023-04-08 17:55:49
 * FileName: 剑指 Offer II 034. 外星语言是否排序.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_II_034__外星语言是否排序 {
    public class Solution {
        public bool IsAlienSorted(string[] words, string order) {
            int[] hash = new int[26];
            for (int i = 0; i < order.Length; ++i) {
                hash[order[i] - 'a'] = i;
            }
            for (int i = 1; i < words.Length; i++) {
                bool valid = false;
                for (int j = 0; j < words[i - 1].Length && j < words[i].Length; j++) {
                    int prev = hash[words[i - 1][j] - 'a'];
                    int curr = hash[words[i][j] - 'a'];
                    if (prev < curr) {
                        valid = true;
                        break;
                    }
                    if (prev > curr) {
                        return false;
                    }
                }
                if (!valid) {
                    if (words[i - 1].Length > words[i].Length) {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsAlienSorted(new[]{"hello","leetcode"}, "hlabcdefgijkmnopqrstuvwxyz");
        Console.WriteLine(ans);
    }
}