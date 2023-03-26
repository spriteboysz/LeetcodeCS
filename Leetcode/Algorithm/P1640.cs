/*
 * Author: Deean
 * Date: 2023-03-26 10:40:51
 * FileName: P1640.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1640 {
    public class Solution {
        public bool CanFormArray(int[] arr, int[][] pieces) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++) {
                dict[arr[i]] = i;
            }
            if (pieces.Any(piece => !dict.ContainsKey(piece[0]))) {
                return false;
            }
            Array.Sort(pieces, (a, b) =>
                dict[a[0]] - dict[b[0]]
            );
            List<int> list = new List<int>();
            foreach (var piece in pieces) {
                list.AddRange(piece);
            }
            int[] arr2 = list.ToArray();
            if (arr.Length != arr2.Length) return false;
            return !arr.Where((t, i) => t != arr2[i]).Any();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CanFormArray(new[] { 3,4,8 }, lib.Arrays.To2DArray("[[3],[5,8]]"));
        Console.WriteLine(ans);
    }
}