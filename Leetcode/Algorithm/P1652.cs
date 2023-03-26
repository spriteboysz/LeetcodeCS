/*
 * Author: Deean
 * Date: 2023-03-26 10:59:37
 * FileName: P1652.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1652 {
    public class Solution {
        public int[] Decrypt(int[] code, int k) {
            int n = code.Length;
            int[] decode = new int[n];
            if (k == 0) return decode;
            int[] code2 = new int [n * 2];
            Array.Copy(code, 0, code2, 0, n);
            Array.Copy(code, 0, code2, n, n);
            int left = k > 0 ? 1 : n + k;
            int right = k > 0 ? k : n - 1;
            int w = 0;
            for (int i = left; i <= right; i++) {
                w += code2[i];
            }
            for (int i = 0; i < n; i++) {
                decode[i] = w;
                w -= code2[left];
                w += code2[right + 1];
                left++;
                right++;
            }
            return decode;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Decrypt(new[] { 5, 7, 1, 4 }, 3);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}