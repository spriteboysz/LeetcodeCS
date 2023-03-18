/*
 * Author: Deean
 * Date: 2023-03-18 15:17:41
 * FileName: P2566.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2566 {
    public class Solution {
        public int MinMaxDifference(int num) {
            var ss = num.ToString();
            var max = num.ToString();
            foreach (var c in ss){
                if (c != '9') {
                    max = ss.Replace(c, '9');
                    break;
                }
            }
            var min = ss.Replace(ss[0], '0');
            return (int)long.Parse(max) - int.Parse(min);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinMaxDifference(456);
        Console.WriteLine(ans);
    }
}