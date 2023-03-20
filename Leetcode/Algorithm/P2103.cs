/*
 * Author: Deean
 * Date: 2023-03-20 22:57:34
 * FileName: P2103.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P2103 {
    public class Solution {
        public int CountPoints(string rings) {
            int[] rod = new int[10];
            for (int i = 0; i < rings.Length; i += 2) {
                switch (rings[i]) {
                    case 'B':
                        rod[rings[i + 1] - '0'] |= 1;
                        break;
                    case 'R':
                        rod[rings[i + 1] - '0'] |= 2;
                        break;
                    case 'G':
                        rod[rings[i + 1] - '0'] |= 4;
                        break;
                    default:
                        return -1;
                }
            }
            int cnt = 0;
            for (int i = 0; i < 10; i++) {
                if (rod[i] == 7) {
                    cnt++;
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountPoints("B0R0G0R9R0B0G0");
        Console.WriteLine(ans);
    }
}