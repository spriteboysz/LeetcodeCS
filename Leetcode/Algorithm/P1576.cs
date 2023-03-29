/*
 * Author: Deean
 * Date: 2023-03-28 23:21:58
 * FileName: P1576.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1576 {
    public class Solution {
        public string ModifyString(string s) {
            int n = s.Length;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < n; i++) {
                if (arr[i] != '?') continue;
                for (char c = 'a'; c <= 'z'; c++) {
                    if ((i > 0 && arr[i - 1] == c) || (i < n - 1 && arr[i + 1] == c)) continue;
                    arr[i] = c;
                    break;
                }
            }
            return new string(arr);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ModifyString("?zs");
        Console.WriteLine(ans);
    }
}