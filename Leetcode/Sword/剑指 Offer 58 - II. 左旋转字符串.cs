/*
 * Author: Deean
 * Date: 2023-04-08 16:52:43
 * FileName: 剑指 Offer 58 - II. 左旋转字符串.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_58___II__左旋转字符串 {
    public class Solution {
        public string ReverseLeftWords(string s, int n) {
            return s.Substring(n) + s.Substring(0, n);
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseLeftWords("abcdefg", 2);
        Console.WriteLine(ans);
    }
}