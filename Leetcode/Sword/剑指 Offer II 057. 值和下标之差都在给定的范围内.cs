/*
 * Author: Deean
 * Date: 2023-05-26 22:31:20
 * FileName: 剑指 Offer II 057. 值和下标之差都在给定的范围内.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_057__值和下标之差都在给定的范围内 {
    public class Solution {
        long Size;

        private long GetIndex(long x) {
            return x >= 0 ? x / Size : (x - 1) / Size - 1;
        }

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
            if (nums.Length < 2) return false;
            Size = t + 1L;
            Dictionary<long, long> dictionary = new Dictionary<long, long>();
            for (int i = 0; i < nums.Length; i++) {
                long x = nums[i];
                long index = GetIndex(x);
                if (dictionary.ContainsKey(index)) return true;
                long l = index - 1L, r = index + 1L;
                if (dictionary.ContainsKey(l) && x - dictionary[l] <= t) return true;
                if (dictionary.ContainsKey(r) && dictionary[r] - x <= t) return true;
                dictionary.Add(index, x);
                if (i >= k) {
                    dictionary.Remove(GetIndex(nums[i - k] * 1L));
                }
            }
            return false;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ContainsNearbyAlmostDuplicate(new[] { 1, 2, 3, 1 }, 3, 0);
        Console.WriteLine(ans);
    }
}