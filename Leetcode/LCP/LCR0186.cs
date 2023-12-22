/*
 * Author: Deean
 * Date: 2023-12-22 22:58:04
 * FileName: LCR0186.cs
 * Description: LCR 186. 文物朝代判断
 */

using System;

namespace LCP;

public class LCR0186 {
    public class Solution {
        public bool CheckDynasty(int[] places) {
            int zero = 0;
            foreach (var place in places) {
                if (place == 0) zero++;
            }
            Array.Sort(places);
            for (int i = zero; i < places.Length - 1; i++) {
                if (places[i] == places[i + 1]) return false;
            }
            return places[places.Length - 1] - places[zero] <= 4;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CheckDynasty(new[] { 0, 6, 9, 0, 7 });
        Console.WriteLine(ans);
    }
}