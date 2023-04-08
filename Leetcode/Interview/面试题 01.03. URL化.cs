/*
 * Author: Deean
 * Date: 2023-04-08 20:17:36
 * FileName: 面试题 01.03. URL化.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_01_03__URL化 {
    public class Solution {
        public string ReplaceSpaces(string S, int length) {
            return S.Substring(0, length).Replace(" ", "%20");
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceSpaces("Mr John Smith    ", 13);
        Console.WriteLine(ans);
    }
}