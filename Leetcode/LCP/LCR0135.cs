/*
 * Author: Deean
 * Date: 2023-11-19 17:19:01
 * FileName: LCR0135.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LCP; 

public class LCR0135 {
    public class Solution {
        public int[] CountNumbers(int cnt) {
            IList<int> list = new List<int>();
            for (int i = 1; i < Math.Pow(10, cnt); i++) {
                list.Add(i);
            }
            return list.ToArray();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountNumbers(2);
        Console.WriteLine(ans);
    }
}