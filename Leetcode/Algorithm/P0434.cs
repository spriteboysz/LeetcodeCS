/*
 * Author: Deean
 * Date: 2023-04-05 19:37:53
 * FileName: P0434.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0434 {
    public class Solution {
        public int CountSegments(string s) {
            string ss = s.Trim();
            int cnt = 0;
            if (ss.Length == 0) return 0;
            for (int i = 1, n = ss.Length; i < n; i++) {
                if (ss[i - 1] == ' ' && ss[i] != ' ') {
                    cnt++;
                }
            }
            return cnt + 1;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountSegments("Hello, my name is John");
        Console.WriteLine(ans);
    }
}