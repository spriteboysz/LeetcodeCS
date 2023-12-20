/*
 * Author: Deean
 * Date: 2023-12-20 21:48:32
 * FileName: LCR0181.cs
 * Description: LCR 181. 字符串中的单词反转
 */

using System;
using System.Text.RegularExpressions;

namespace LCP;

public class LCR0181 {
    public class Solution {
        public string ReverseMessage(string message) {
            string[] words = Regex.Split(message.Trim(), @"\s+");
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseMessage("the sky is blue");
        Console.WriteLine(ans);
    }
}