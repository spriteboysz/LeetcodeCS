/*
 * Author: Deean
 * Date: 2023-03-31 21:10:36
 * FileName: P1323.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1323 {
    public class Solution {
        public int Maximum69Number(int num) {
            string ss = num.ToString();
            for (int i = 0; i < ss.Length; i++) {
                if (ss[i] == '6') {
                    ss = ss.Substring(0, i) + '9' + ss.Substring(i + 1);
                    break;
                }
            }
            return int.Parse(ss);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Maximum69Number(9669);
        Console.WriteLine(ans);
    }
}