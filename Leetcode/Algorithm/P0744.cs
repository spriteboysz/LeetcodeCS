/*
 * Author: Deean
 * Date: 2023-04-04 12:14:42
 * FileName: P0744.cs
 * Description:
*/

using System;

namespace Algorithm;

public class P0744 {
    public class Solution {
        public char NextGreatestLetter(char[] letters, char target) {
            foreach (var letter in letters) {
                if (letter > target) {
                    return letter;
                }
            }
            return letters[0];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'c');
        Console.WriteLine(ans);
    }
}