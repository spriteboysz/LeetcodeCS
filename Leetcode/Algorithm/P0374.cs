/*
 * Author: Deean
 * Date: 2023-04-05 23:02:10
 * FileName: P0374.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0374 {
    public class Solution {
        private int guess(int num) {
            if (num == 6) return 0;
            return num < 6 ? 1 : -1;
        }

        public int GuessNumber(int n) {
            int left = 1, right = n;
            while (left < right) {
                int mid = left + (right - left) / 2;
                if (guess(mid) == -1) {
                    right = mid-1;
                } else if (guess(mid) == 1) {
                    left = mid+1;
                } else {
                    return mid;
                }
            }
            return left;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GuessNumber(10);
        Console.WriteLine(ans);
    }
}