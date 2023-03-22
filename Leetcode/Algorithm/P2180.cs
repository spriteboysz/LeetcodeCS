/*
 * Author: Deean
 * Date: 2023-03-21 23:30:35
 * FileName: P2180.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2180 {
    public class Solution {
        public int CountEven(int num) {
            int cnt = 0;
            for (int i = 1; i <= num; i++) {
                int sum = i.ToString().ToCharArray().Select(c => c - '0').Sum();
                if (sum % 2 == 0) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountEven(30);
        Console.WriteLine(ans);
    }
}