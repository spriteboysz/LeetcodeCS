/*
 * Author: Deean
 * Date: 2023-03-19 22:52:30
 * FileName: P2094.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P2094 {
    public class Solution {
        public int[] FindEvenNumbers(int[] digits) {
            int[] hash = new int[10];
            foreach (var digit in digits) {
                hash[digit]++;
            }
            IList<int> even = new List<int>();
            for (int i = 100; i < 1000; i += 2) {
                int[] hash1 = new int[10];
                int num = i;
                bool flag = true;
                while (num > 0) {
                    int digit = num % 10;
                    hash1[digit]++;
                    if (hash1[digit] > hash[digit]) {
                        flag = false;
                        break;
                    }
                    num /= 10;
                }
                if (flag) even.Add(i);
            }
            return even.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindEvenNumbers(new[] { 2, 1, 3, 0 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}