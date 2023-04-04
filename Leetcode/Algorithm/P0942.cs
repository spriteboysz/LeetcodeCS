/*
 * Author: Deean
 * Date: 2023-04-04 08:51:30
 * FileName: P0942.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0942 {
    public class Solution {
        public int[] DiStringMatch(string s) {
            IList<int> list = new List<int>();
            int left = 0, right = s.Length;
            foreach (var c in s) {
                list.Add(c == 'I' ? left++ : right--);
            }
            list.Add(left);
            return list.ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DiStringMatch("IDID");
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}