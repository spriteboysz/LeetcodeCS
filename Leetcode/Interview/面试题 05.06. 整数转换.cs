/*
 * Author: Deean
 * Date: 2023-04-09 11:32:46
 * FileName: 面试题 05.06. 整数转换.cs
 * Description:
*/

using System;

namespace Interview;

public class 面试题_05_06__整数转换 {
    public class Solution {
        public int ConvertInteger(int A, int B) {
            int xor = A ^ B, cnt = 0;
            while (xor != 0) {
                cnt += xor & 1;
                xor >>= 1;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertInteger(29, 15);
        Console.WriteLine(ans);
    }
}