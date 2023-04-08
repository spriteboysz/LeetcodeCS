/*
 * Author: Deean
 * Date: 2023-04-08 19:44:35
 * FileName: 剑指 Offer II 068. 查找插入位置.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_II_068__查找插入位置 {
    public class Solution {
        public int SearchInsert(int[] nums, int target) {
            int low = 0, high = nums.Length - 1;
            while (low <= high) {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target) {
                    return mid;
                } 
                if (nums[mid] > target) {
                    high = mid - 1;
                } else {
                    low = mid + 1;
                }
            }
            return low;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SearchInsert(new[] { 1, 3, 5, 6 }, 5);
        Console.WriteLine(ans);
    }
}