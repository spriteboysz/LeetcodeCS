/*
 * Author: Deean
 * Date: 2023-04-09 10:00:15
 * FileName: 面试题 16.05. 阶乘尾数.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_16_05__阶乘尾数 {
    public class Solution {
        public int TrailingZeroes(int n) {
            int cnt = 0;
            while (n > 0) {
                n /= 5;
                cnt += n;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrailingZeroes(5);
        Console.WriteLine(ans);
    }
}