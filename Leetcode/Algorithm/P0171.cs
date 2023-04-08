/*
 * Author: Deean
 * Date: 2023-04-08 08:54:10
 * FileName: P0171.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0171 {
    public class Solution {
        public int TitleToNumber(string columnTitle) {
            int num = 0;
            foreach (var title in columnTitle) {
                num = num * 26 + title - 'A' + 1;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TitleToNumber("AB");
        Console.WriteLine(ans);
    }
}