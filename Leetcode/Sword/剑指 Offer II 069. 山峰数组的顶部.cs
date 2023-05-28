/*
 * Author: Deean
 * Date: 2023-05-28 10:11:15
 * FileName: 剑指 Offer II 069. 山峰数组的顶部.cs
 * Description:
*/

using System;

namespace Sword; 

public class 剑指_Offer_II_069__山峰数组的顶部 {
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
        var ans = s.PeakIndexInMountainArray(new[] { 1, 3, 5, 4, 2 });
        Console.WriteLine(ans);
    }
}