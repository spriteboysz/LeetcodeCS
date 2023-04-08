/*
 * Author: Deean
 * Date: 2023-04-08 16:43:53
 * FileName: 剑指 Offer 58 - I. 翻转单词顺序.cs
 * Description:
*/

using System;
using System.Text.RegularExpressions;

namespace Sword; 

public class 剑指_Offer_58___I__翻转单词顺序 {
    public class Solution {
        public string ReverseWords(string s) {
            string[] words = Regex.Split(s.Trim(), @"\s+");
            Array.Reverse(words);
            return string.Join(" ", words);
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseWords("  hello world!  ");
        Console.WriteLine(ans);
    }
}