/*
 * Author: Deean
 * Date: 2023-04-05 16:00:28
 * FileName: P0520.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0520 {
    public class Solution {
        public bool DetectCapitalUse(string word) {
            if (word.Length >= 2 && char.IsLower(word[0]) && char.IsUpper(word[1])) {
                return false;
            }
        
            for (int i = 2; i < word.Length; ++i) {
                if (char.IsLower(word[i]) ^ char.IsLower(word[1])) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.DetectCapitalUse("USA");
        Console.WriteLine(ans);
        ans = s.DetectCapitalUse("FlaG");
        Console.WriteLine(ans);
    }
}