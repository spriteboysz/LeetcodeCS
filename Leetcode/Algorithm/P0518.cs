/*
 * Author: Deean
 * Date: 2023-05-28 10:37:24
 * FileName: P0518.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0518 {
    public class Solution {
        private int[] pref;
        private int total;
        private Random random;

        public Solution(int[] w) {
            random = new Random();
            int n = w.Length;
            pref = new int[n + 1];
            for (int i = 0; i < n; i++) {
                pref[i + 1] = pref[i] + w[i];
            }
            total = pref[n];
        }

        public int PickIndex() {
            int target = random.Next(total);
            return BinarySearch(target);
        }

        private int BinarySearch(int num) {
            int left = 0, right = pref.Length - 2;
            while (left < right) {
                int mid = left + (right - left + 1) / 2;
                if (pref[mid] <= num) {
                    left = mid;
                } else {
                    right = mid - 1;
                }
            }
            return left;
        }
    }

    public static void Test() {
        Solution obj = new Solution(new[] { 1, 3 });
        Console.WriteLine(obj.PickIndex());
        Console.WriteLine(obj.PickIndex());
        Console.WriteLine(obj.PickIndex());
    }
}