/*
 * Author: Deean
 * Date: 2023-04-01 23:08:30
 * FileName: P1046.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P1046 {
    public class Solution {
        public int LastStoneWeight(int[] stones) {
            List<int> list = new List<int>(stones);
            while (list.Count > 1) {
                list.Sort((a, b)=> b - a);
                int a = list[0], b = list[1];
                list.RemoveAt(0);
                list.RemoveAt(0);
                if (a != b) {
                    list.Add(Math.Abs(a - b));
                }
            } 
            return list.Count == 1 ? list[0] : 0;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LastStoneWeight(new []{2,7,4,1,8,1});
        Console.WriteLine(ans);
    }
}