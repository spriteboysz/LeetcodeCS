/*
 * Author: Deean
 * Date: 2023-03-19 13:35:10
 * FileName: P2231.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2231 {
    public class Solution {
        public int LargestInteger(int num) {
            List<int> even = new(), odd = new();
            List<int> evenIndex = new(), oddIndex = new();
            string s = num.ToString();
            int n = s.Length;
            for (int i = 0; i < n; i++) {
                int digit = s[i] - '0';
                if (digit % 2 == 0) {
                    even.Add(digit);
                    evenIndex.Add(i);
                } else {
                    odd.Add(digit);
                    oddIndex.Add(i);
                }
            }
            even.Sort((a, b) => b - a);
            odd.Sort((a, b) => b - a);
            int[] digits = new int[n];
            int pos1 = 0, pos2 = 0, largest = 0;
            foreach (var index in evenIndex) {
                digits[index] = even[pos1++];
            }
            foreach (var index in oddIndex) {
                digits[index] = odd[pos2++];
            }

            for (int i = 0; i < n; i++) {
                largest = largest * 10 + digits[i];
            }
            return largest;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LargestInteger(65875);
        Console.WriteLine(ans);
    }
}