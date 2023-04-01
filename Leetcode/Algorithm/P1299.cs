/*
 * Author: Deean
 * Date: 2023-03-31 21:54:52
 * FileName: P1299.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P1299 {
    public class Solution {
        public int[] ReplaceElements(int[] arr) {
            int maximum = -1, n = arr.Length;
            for (int i = n - 1; i >= 0; i--) {
                int cur = arr[i];
                arr[i] = maximum;
                maximum = Math.Max(maximum, cur);
            }
            return arr;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReplaceElements(new[]{17,18,5,4,6,1});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}