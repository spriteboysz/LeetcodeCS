/*
 * Author: Deean
 * Date: 2023-04-05 16:19:53
 * FileName: P0541.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0541 {
    public class Solution {
        private void Process(char[] cs, int left, int right) {
            while (left < right) {
                char temp = cs[left];
                cs[left] = cs[right];
                cs[right] = temp;
                left++;
                right--;
            }
        }

        public string ReverseStr(string s, int k) {
            char[] cs = s.ToCharArray();
            int n = s.Length;
            for (int i = 0; i < n; i += 2 * k) {
                Process(cs, i, Math.Min(i + k, n) - 1);
            }
            return new string(cs);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseStr("abcdefg", 2);
        Console.WriteLine(ans);
    }
}