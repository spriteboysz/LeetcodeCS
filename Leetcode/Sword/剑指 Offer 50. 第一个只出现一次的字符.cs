/*
 * Author: Deean
 * Date: 2023-04-08 16:04:52
 * FileName: 剑指 Offer 50. 第一个只出现一次的字符.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_50__第一个只出现一次的字符 {
    public class Solution {
        public char FirstUniqChar(string s) {
            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var c in s) {
                if (!dict.ContainsKey(c)) {
                    dict.Add(c, 0);
                }
                dict[c]++;
            }
            foreach (var c in s) {
                if (dict[c] == 1) {
                    return c;
                }
            }
            return ' ';
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FirstUniqChar("abaccdeff");
        Console.WriteLine(ans);
    }
}