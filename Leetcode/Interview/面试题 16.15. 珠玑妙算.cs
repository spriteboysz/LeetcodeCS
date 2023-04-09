/*
 * Author: Deean
 * Date: 2023-04-08 22:28:46
 * FileName: 面试题 16.15. 珠玑妙算.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Interview;

public class 面试题_16_15__珠玑妙算 {
    public class Solution {
        public int[] MasterMind(string solution, string guess) {
            int hit = 0, pseudo = 0;
            IDictionary<char, int> dict1 = new Dictionary<char, int>();
            IDictionary<char, int> dict2 = new Dictionary<char, int>();
            for (int i = 0; i < 4; i++) {
                if (solution[i] == guess[i]) {
                    hit++;
                } else {
                    if (!dict1.ContainsKey(solution[i])) {
                        dict1.Add(solution[i], 0);
                    }
                    dict1[solution[i]]++;
                    if (!dict2.ContainsKey(guess[i])) {
                        dict2.Add(guess[i], 0);
                    }
                    dict2[guess[i]]++;
                }
            }
            foreach (var color in new[] { 'R', 'Y', 'G', 'B' }) {
                if (dict1.ContainsKey(color) && dict2.ContainsKey(color)) {
                    pseudo += Math.Min(dict1[color], dict2[color]);
                }
            }
            return new[] { hit, pseudo };
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MasterMind("RGBY", "GGRR");
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}