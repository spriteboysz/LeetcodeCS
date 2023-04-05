/*
 * Author: Deean
 * Date: 2023-04-05 15:39:58
 * FileName: P0506.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P0506 {
    public class Solution {
        public string[] FindRelativeRanks(int[] score) {
            string[] ranks = { "", "Gold Medal", "Silver Medal", "Bronze Medal" };
            int n = score.Length;
            int[] sorted = new int[n];
            for (int i = 0; i < n; i++) {
                sorted[i] = score[i];
            }
            Array.Sort(sorted, (a, b)=>b - a);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++) {
                dict.Add(sorted[i], i + 1);
            }
            string[] relative = new string[n];
            for (int i = 0; i < n; i++) {
                int rank = dict[score[i]];
                relative[i] = rank <= 3 ? ranks[rank] : rank.ToString();
            }
            return relative;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindRelativeRanks(new[]{5,4,3,2,1});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}