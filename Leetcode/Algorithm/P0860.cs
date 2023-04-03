/*
 * Author: Deean
 * Date: 2023-04-02 21:29:23
 * FileName: P0860.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0860 {
    public class Solution {
        public bool LemonadeChange(int[] bills) {
            int bill05 = 0, bill10 = 0;
            foreach (var bill in bills) {
                if (bill == 5) {
                    bill05++;
                } else if (bill == 10) {
                    if (bill05 < 1) {
                        return false;
                    }
                    bill10++;
                    bill05--;
                } else if (bill == 20) {
                    if (bill10 > 0) {
                        if (bill05 < 1) {
                            return false;
                        }
                        bill05--;
                        bill10--;
                    } else {
                        if (bill05 < 3) {
                            return false;
                        }
                        bill05 -= 3;
                    }
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.LemonadeChange(new[] { 5, 5, 5, 10, 20 });
        Console.WriteLine(ans);
    }
}