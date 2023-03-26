/*
 * Author: Deean
 * Date: 2023-03-26 22:47:27
 * FileName: P1431.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1431 {
    public class Solution {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
            int max = candies.Max();
            return candies.Select(candy => candy + extraCandies >= max).ToList();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}