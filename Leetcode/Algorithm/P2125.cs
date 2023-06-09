/*
 * Author: Deean
 * Date: 2023-06-08 22:55:35
 * FileName: P2125.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2125 {
    public class Solution {
        public int NumberOfBeams(string[] bank) {
            int last = 0, count = 0;
            foreach (string row in bank) {
                int countDevice = 0;
                foreach (char c in row) {
                    countDevice += c - '0';
                }
                if (countDevice > 0) {
                    count += last * countDevice;
                    last = countDevice;
                }
            }
            return count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumberOfBeams(new[] { "011001", "000000", "010100", "001000" });
        Console.WriteLine(ans);
    }
}