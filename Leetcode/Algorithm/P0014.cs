/*
 * Author: Deean
 * Date: 2023-04-08 11:48:15
 * FileName: P0014.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0014 {
    public class Solution {
        public string LongestCommonPrefix(string[] strs) {
            string common = strs[0];
            for (int i = 1, n = strs.Length; i < n; i++) {
                for (int j = common.Length; j >= 0; j--) {
                    if (strs[i].StartsWith(common.Substring(0, j))) {
                        common = common.Substring(0, j);
                        break;
                    }
                }
            }
            return common;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LongestCommonPrefix(new[] { "flower", "flow", "flight" });
        Console.WriteLine(ans);
    }
}