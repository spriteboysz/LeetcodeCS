/*
 * Author: Deean
 * Date: 2023-04-01 22:23:21
 * FileName: P1189.cs
 * Description:
*/

using System;
using System.Linq;

namespace Algorithm; 

public class P1189 {
    public class Solution {
        public int MaxNumberOfBalloons(string text) {
            int[] balloon = new int[5];
            foreach (var c in text) {
                switch (c) {
                    case 'b':
                        balloon[0] += 2;
                        break;
                    case 'a':
                        balloon[1] += 2;
                        break;
                    case 'l':
                        balloon[2] += 1;
                        break;
                    case 'o':
                        balloon[3] += 1;
                        break;
                    case 'n':
                        balloon[4] += 2;
                        break;
                }
            }
            return balloon.Min() / 2;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxNumberOfBalloons("loonbalxballpoon");
        Console.WriteLine(ans);
    }
}