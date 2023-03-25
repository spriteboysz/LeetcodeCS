/*
 * Author: Deean
 * Date: 2023-03-24 21:54:30
 * FileName: P1903.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1903 {
    public class Solution {
        public string LargestOddNumber(string num) {
            int n = num.Length;
            for (int i = n - 1; i >= 0; i--) {
                if ((num[i] - '0') % 2 != 0) {
                    return num.Substring(0, i + 1);
                }
            }
            return "";
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestOddNumber("52");
        Console.WriteLine(ans);
    }
}