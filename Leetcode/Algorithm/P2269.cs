/*
 * Author: Deean
 * Date: 2023-03-19 11:57:28
 * FileName: P2269.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2269 {
    public class Solution {
        public int DivisorSubstrings(int num, int k) {
            string ss = num.ToString();
            int n = ss.Length;
            if (n < k) return 0;
            int cnt = 0;
            for (int i = 0; i + k <= n; i++) {
                int temp = Convert.ToInt32(ss.Substring(i, k));
                if (temp != 0 && num % temp == 0) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DivisorSubstrings(240, 2);
        Console.WriteLine(ans);
    }
}