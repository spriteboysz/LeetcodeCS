/*
 * Author: Deean
 * Date: 2023-04-08 09:01:28
 * FileName: P0168.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P0168 {
    public class Solution {
        public string ConvertToTitle(int columnNumber) {
            StringBuilder title = new StringBuilder();
            while (columnNumber > 0) {
                int cur = (columnNumber - 1) % 26 + 1;
                title.Append((char)(cur - 1 + 'A'));
                columnNumber = (columnNumber - cur) / 26;
            }
            char[] cs = title.ToString().ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertToTitle(701);
        Console.WriteLine(ans);
    }
}