/*
 * Author: Deean
 * Date: 2023-05-28 10:16:17
 * FileName: P0852.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0852 {
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
        var ans = s.PeakIndexInMountainArray(new[] { 0, 2, 1, 0 });
        Console.WriteLine(ans);
    }
}