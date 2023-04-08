/*
 * Author: Deean
 * Date: 2023-04-08 11:39:16
 * FileName: P0020.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0020 {
    public class Solution {
        public bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s) {
                if (stack.Count == 0) {
                    stack.Push(c);
                } else if (c == ')' && stack.Peek() == '(') {
                    stack.Pop();
                } else if (c == ']' && stack.Peek() == '[') {
                    stack.Pop();
                } else if (c == '}' && stack.Peek() == '{') {
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsValid("()[]{}");
        Console.WriteLine(ans);
    }
}