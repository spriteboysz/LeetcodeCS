/*
 * Author: Deean
 * Date: 2023-03-19 08:43:06
 * FileName: P2379.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2379 {
    public class Solution {
        public int MinimumRecolors(string blocks, int k) {
            int left = 0, right = 0, cnt = 0, cur = 0;
            while (right < k) {
                cur += blocks[right] == 'W' ? 1 : 0;
                right++;
            }
            cnt = cur;
            while (right < blocks.Length) {
                cur += blocks[right] == 'W' ? 1 : 0;
                cur -= blocks[left] == 'W' ? 1 : 0;
                cnt = Math.Min(cnt, cur);
                left++;
                right++;
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumRecolors("WBBWWBBWBW", 7);
        Console.WriteLine(ans);
    }
}