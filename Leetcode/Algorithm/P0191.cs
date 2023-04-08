/*
 * Author: Deean
 * Date: 2023-04-07 23:28:19
 * FileName: P0191.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0191 {
    public class Solution {
        public int HammingWeight(uint n) {
            int cnt = 0;
            while (n > 0) {
                cnt += (int) n & 1;
                n >>= 1;
            }
            return cnt;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.HammingWeight(3);
        Console.WriteLine(ans);
    }
}