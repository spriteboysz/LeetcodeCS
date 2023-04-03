/*
 * Author: Deean
 * Date: 2023-04-02 22:19:01
 * FileName: P0888.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0888 {
    public class Solution {
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
            int aliceSum = aliceSizes.Sum(), bobSum = bobSizes.Sum();
            HashSet<int> bobSet = new HashSet<int>();
            foreach (var size in bobSizes) {
                bobSet.Add(size);
            }

            int diff = (aliceSum - bobSum) / 2;
            int[] exchange = new int[2];
            foreach (var size in aliceSizes) {
                if (bobSet.Contains(size - diff)) {
                    exchange[0] = size;
                    exchange[1] = size - diff;
                    break;
                }
            }
            return exchange;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FairCandySwap(new[] { 1, 1 }, new[] { 2, 2 });
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}