/*
 * Author: Deean
 * Date: 2023-08-16 23:15:59
 * FileName: P2729.cs
 * Description:2729. 判断一个数是否迷人
 */

using System;
using System.Text;

namespace Algorithm;

public class P2729 {
    public class Solution {
        public bool IsFascinating(int n) {
            StringBuilder ss = new StringBuilder();
            for (int i = 1; i <= 3; i++) {
                ss.Append((n * i).ToString());
            }
            int[] digits = new int[10];
            foreach (var c in ss.ToString()) {
                digits[c - '0']++;
            }
            for (int i = 1; i < 10; i++) {
                if (digits[i] != 1) {
                    return false;
                }
            }
            return digits[0] == 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsFascinating(192);
        Console.WriteLine(ans);
    }
}