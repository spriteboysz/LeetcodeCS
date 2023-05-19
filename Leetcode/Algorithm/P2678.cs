/*
 * Author: Deean
 * Date: 2023-05-19 21:47:38
 * FileName: P2678.cs
 * Description: 2678. 老人的数目
*/

using System;

namespace Algorithm;

public class P2678 {
    public class Solution {
        public int CountSeniors(string[] details) {
            int cnt = 0;
            foreach (var detail in details) {
                if (int.Parse(detail.Substring(11, 2)) > 60) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        string[] details = { "7868190130M7522", "5303914400F9211", "9273338290F4010" };
        var s = new Solution();
        var ans = s.CountSeniors(details);
        Console.WriteLine(ans);
    }
}