/*
 * Author: Deean
 * Date: 2023-03-29 22:49:39
 * FileName: P1417.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm;

public class P1417 {
    public class Solution {
        public string Reformat(string s) {
            StringBuilder digits = new StringBuilder();
            StringBuilder nums = new StringBuilder();
            int pos1 = 0, pos2 = 0;
            foreach (var c in s) {
                if (char.IsDigit(c)) {
                    digits.Append(c);
                    pos1++;
                } else {
                    nums.Append(c);
                    pos2++;
                }
            }
            if (Math.Abs(pos1 - pos2) > 1) return "";
            string s1 = pos1 > pos2 ? digits.ToString() : nums.ToString();
            string s2 = pos1 > pos2 ? nums.ToString() : digits.ToString();
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s1.Length; i++) {
                ss.Append(s1[i]);
                if (i < s2.Length) ss.Append(s2[i]);
            }
            return ss.ToString();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Reformat("covid2019");
        Console.WriteLine(ans);
    }
}