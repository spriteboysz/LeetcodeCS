/*
 * Author: Deean
 * Date: 2023-03-18 15:53:23
 * FileName: P2588.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2588 {
    public class Solution {
        public long PickGifts(int[] gifts, int k) {
            while (k > 0) {
                int index = Array.IndexOf(gifts, gifts.Max());
                gifts[index] = (int)Math.Sqrt(gifts[index]);
                k--;
            }
            return gifts.Aggregate((long)0, (current, t) => current + t);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PickGifts(new[] { 25, 64, 9, 4, 100 }, 4);
        Console.WriteLine(ans);
    }
}