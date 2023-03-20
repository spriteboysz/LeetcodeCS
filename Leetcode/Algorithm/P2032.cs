/*
 * Author: Deean
 * Date: 2023-03-19 19:55:20
 * FileName: P2032.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2032 {
    public class Solution {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
            int[] number = new int[101];
            foreach (var num in nums1) {
                number[num] |= 1;
            }
            foreach (var num in nums2) {
                number[num] |= 2;
            }
            foreach (var num in nums3) {
                number[num] |= 4;
            }

            IList<int> list = new List<int>();
            for (int i = 0; i < 101; i++) {
                if (number[i] == 3 || number[i] >= 5) {
                    list.Add(i);
                }
            }
            return list;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TwoOutOfThree(new[] { 1, 1, 3, 2 }, new[] { 2, 3 }, new[] { 3 });
        Console.WriteLine(ans);
    }
}