/*
 * Author: Deean
 * Date: 2023-06-07 23:38:41
 * FileName: P2710.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2710 {
    public class Solution {
        public string RemoveTrailingZeros(string num) {
            for (int i = num.Length - 1; i >= 0; i--) {
                if (num[i] != '0') {
                    return num.Substring(0, i + 1);
                }
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveTrailingZeros("51230100");
        Console.WriteLine(ans);
    }
}