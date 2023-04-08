/*
 * Author: Deean
 * Date: 2023-04-08 13:08:13
 * FileName: 剑指 Offer 05. 替换空格.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_05__替换空格 {
    public class Solution {
        public string ReplaceSpace(string s) {
            return s.Replace(" ", "%20");
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceSpace("We are happy.");
        Console.WriteLine(ans);
    }
}