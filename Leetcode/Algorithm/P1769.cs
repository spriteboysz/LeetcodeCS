/*
 * Author: Deean
 * Date: 2023-06-06 23:05:33
 * FileName: P1769.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1769 {
    public class Solution {
        public int[] MinOperations(string boxes) {
            int n = boxes.Length;
            int[] count = new int[n];
            for (int i = 0; i < n; i++) {
                int cnt = 0;
                for (int j = 0; j < n; j++) {
                    if (boxes[j] == '1') {
                        cnt += Math.Abs(j - i);
                    }
                }
                count[i] = cnt;
            }
            return count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinOperations("110");
        Console.WriteLine(Arrays.ToString(ans));
    }
}