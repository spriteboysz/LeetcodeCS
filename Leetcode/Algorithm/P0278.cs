/*
 * Author: Deean
 * Date: 2023-04-06 23:45:05
 * FileName: P0278.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0278 {
    public class Solution {
        bool IsBadVersion(int version) {
            return version > 4;
        }

        public int FirstBadVersion(int n) {
            int left = 1, right = n;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid)) {
                    right = mid;
                } else {
                    left = mid + 1;
                }
            }
            return left;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FirstBadVersion(5);
        Console.WriteLine(ans);
    }
}