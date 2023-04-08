/*
 * Author: Deean
 * Date: 2023-04-08 19:51:47
 * FileName: 剑指 Offer II 075. 数组相对排序.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_075__数组相对排序 {
    public class Solution {
        public int[] RelativeSortArray(int[] arr1, int[] arr2) {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr2.Length; i++) {
                dict.Add(arr2[i], i);
            }
            foreach (var num in arr1) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 1001);
                }
            }
            Array.Sort(arr1, (a, b) => dict[a] == dict[b] ? a - b : dict[a] - dict[b]);
            return arr1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RelativeSortArray(new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new[] { 2, 1, 4, 3, 9, 6 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}