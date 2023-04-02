/*
 * Author: Deean
 * Date: 2023-04-02 17:05:37
 * FileName: P0989.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0989 {
    public class Solution {
        public IList<int> AddToArrayForm(int[] num, int k) {
            IList<int> sum = new List<int>();
            for (int i = num.Length - 1; i >= 0; i--) {
                k += num[i];
                sum.Add(k % 10);
                k /= 10;
            }
            while (k > 0) {
                sum.Add(k % 10);
                k /= 10;
            }
            return sum.Reverse().ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AddToArrayForm(new[]{2,1,5}, 806);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}