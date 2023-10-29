/*
 * Author: Deean
 * Date: 2023-10-24 23:35:57
 * FileName: LCR0069.cs
 * Description: LCR 069. 山脉数组的峰顶索引
 */

using System;

namespace LCP;

public class LCR0069 {
    public class Solution {
        public int PeakIndexInMountainArray(int[] arr) {
            int left = 1, right = arr.Length - 2, peak = 0;
            while (left <= right) {
                int mid = (left + right) / 2;
                if (arr[mid] > arr[mid + 1]) {
                    peak = mid;
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            return peak;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PeakIndexInMountainArray(new[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 });
        Console.WriteLine(ans);
    }
}