/*
 * Author: Deean
 * Date: 2023-04-04 11:09:21
 * FileName: P0771.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0771 {
    public class Solution {
        public int NumJewelsInStones(string jewels, string stones) {
            int cnt = 0;
            foreach (var jewel in jewels) {
                foreach (var stone in stones) {
                    if (jewel == stone) {
                        cnt++;
                    }
                }
            }
            return cnt;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumJewelsInStones("aA", "aAAbbbb");
        Console.WriteLine(ans);
    }
}