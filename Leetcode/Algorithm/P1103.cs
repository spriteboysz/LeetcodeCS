/*
 * Author: Deean
 * Date: 2023-03-31 23:39:40
 * FileName: P1103.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1103 {
    public class Solution {
        public int[] DistributeCandies(int candies, int num_people) {
            int[] distributed = new int[num_people];
            int index = 0, count = 1;
            while (candies > 0) {
                int cur = Math.Min(candies, count);
                distributed[index] += cur;
                candies -= cur;
                index = (index + 1) % num_people;
                count++;
            }
            return distributed;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DistributeCandies(7, 4);
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}