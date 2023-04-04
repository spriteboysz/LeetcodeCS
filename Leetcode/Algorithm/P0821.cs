/*
 * Author: Deean
 * Date: 2023-04-04 10:09:19
 * FileName: P0821.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P0821 {
    public class Solution {
        public int[] ShortestToChar(string s, char c) {
            int n = s.Length;
            int[] shortest = new int[n];
            for (int i = 0, index = -n; i < n; i++) {
                if (s[i] == c) {
                    index = i;
                }
                shortest[i] = i - index;
            }
            for (int i = n - 1, index = 2 * n; i >= 0; i--) {
                if (s[i] == c) {
                    index = i;
                }
                shortest[i] = Math.Min(shortest[i], index - i);
            }
            return shortest;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ShortestToChar("loveleetcode", 'e');
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}