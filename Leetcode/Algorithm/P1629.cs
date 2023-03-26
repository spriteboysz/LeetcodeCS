/*
 * Author: Deean
 * Date: 2023-03-26 10:28:21
 * FileName: P1629.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P1629 {
    public class Solution {
        public char SlowestKey(int[] releaseTimes, string keysPressed) {
            int maximum = releaseTimes[0];
            char slowest = keysPressed[0];
            for (int i = 1; i < releaseTimes.Length; i++) {
                char key = keysPressed[i];
                int time = releaseTimes[i] - releaseTimes[i - 1];
                if (time > maximum || (time == maximum && key > slowest)) {
                    maximum = time;
                    slowest = key;
                }
            }
            return slowest;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SlowestKey(new[] { 9, 29, 49, 50 }, "cbcd");
        Console.WriteLine(ans);
    }
}