/*
 * Author: Deean
 * Date: 2023-03-26 14:08:01
 * FileName: P1716.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1716 {
    public class Solution {
        public int TotalMoney(int n) {
            int week = 1, day = 1, cnt = 0;
            for (int i = 0; i < n; i++) {
                cnt += week + day - 1;
                day++;
                if (day == 8) {
                    week += 1;
                    day = 1;
                }
            }
            return cnt;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TotalMoney(10);
        Console.WriteLine(ans);
    }
}