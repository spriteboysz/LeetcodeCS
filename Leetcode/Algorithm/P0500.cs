/*
 * Author: Deean
 * Date: 2023-04-04 22:25:38
 * FileName: P0500.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0500 {
    public class Solution {
        public string[] FindWords(string[] words) {
            Dictionary<char, int> board = new Dictionary<char, int>();
            foreach (var c in "qwertyuiop") {
                board.Add(c, 1);
            }
            foreach (var c in "asdfghjkl") {
                board.Add(c, 2); 
            }
            foreach (var c in "zxcvbnm") {
                board.Add(c, 4);
            }

            IList<string> target = new List<string>();
            foreach (var word in words) {
                int value = 0;
                foreach (var c in word) {
                    value |= board[char.ToLower(c)];
                }
                if (value == 1 || value == 2 || value == 4) {
                    target.Add(word);
                }
            }
            return target.ToArray();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindWords(new[]{"Hello","Alaska","Dad","Peace"});
        Console.WriteLine(lib.Arrays.ToString(ans));
    }
}