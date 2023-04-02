/*
 * Author: Deean
 * Date: 2023-04-01 22:30:17
 * FileName: P1200.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1200 {
    public class Solution {
        public IList<IList<int>> MinimumAbsDifference(int[] arr) {
            Array.Sort(arr);
            int minimum = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++) {
                minimum = Math.Min(minimum, arr[i] - arr[i - 1]);
            }
            IList<IList<int>> different = new List<IList<int>>();
            for (int i = 1; i < arr.Length; i++) {
                List<int> item = new List<int>();
                if (arr[i] - arr[i - 1] == minimum) {
                    item.Add(arr[i - 1]);
                    item.Add(arr[i]);
                    different.Add(item);
                }
            }
            return different;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MinimumAbsDifference(new []{3,8,-10,23,19,-4,-14,27});
        Console.WriteLine(ans);
    }
}