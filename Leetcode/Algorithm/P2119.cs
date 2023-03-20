/*
 * Author: Deean
 * Date: 2023-03-20 23:25:05
 * FileName: P2119.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2119 {
    public class Solution {
        public bool IsSameAfterReversals(int num) {
            if (num == 0) return true;
            return num % 10 != 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsSameAfterReversals(526);
        Console.WriteLine(ans);
    }
}