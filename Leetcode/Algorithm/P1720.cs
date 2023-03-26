/*
 * Author: Deean
 * Date: 2023-03-26 14:10:34
 * FileName: P1720.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1720 {
    public class Solution {
        public int[] Decode(int[] encoded, int first) {
            int n = encoded.Length;
            int[] decoded = new int[n + 1];
            decoded[0] = first;
            for (int i = 0; i < n; i++) {
                decoded[i + 1] = decoded[i] ^ encoded[i];
            }
            return decoded;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Decode(new[] { 1, 2, 3 }, 1);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}