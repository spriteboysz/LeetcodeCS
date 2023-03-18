/*
 * Author: Deean
 * Date: 2023-03-18 14:28:46
 * FileName: P2582.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2582 {
    public class Solution {
        public int PassThePillow(int n, int time) {
            int mod = time % (n - 1);
            return time / (n - 1) % 2 == 1 ? n - mod : mod + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PassThePillow(4, 5);
        Console.WriteLine(ans);
    }
}