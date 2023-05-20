/*
 * Author: Deean
 * Date: 2023-05-20 15:21:58
 * FileName: P2660.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm;

public class P2660 {
    public class Solution {
        public int Process(int[] player) {
            int n = player.Length;
            int[] flag = Enumerable.Repeat(0, n).ToArray();
            for (int i = 0; i < n; i++) {
                if (player[i] == 10) {
                    if (i + 1 < n) flag[i + 1] = 1;
                    if (i + 2 < n) flag[i + 2] = 1;
                }
            }
            int score = 0;
            for (int i = 0; i < player.Length; i++) {
                score += player[i] * (flag[i] + 1);
            }
            return score;
        }

        public int IsWinner(int[] player1, int[] player2) {
            int score1 = Process(player1), score2 = Process(player2);
            if (score1 == score2) return 0;
            return score1 > score2 ? 1 : 2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsWinner(new[] { 4, 10, 7, 9 }, new[] { 6, 5, 2, 3 });
        Console.WriteLine(ans);
    }
}