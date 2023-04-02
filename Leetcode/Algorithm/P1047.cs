/*
 * Author: Deean
 * Date: 2023-04-01 23:03:01
 * FileName: P1047.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P1047 {
    public class Solution {
        public string RemoveDuplicates(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s) {
                if (stack.Count == 0) {
                    stack.Push(c);
                } else if (stack.Peek() == c) {
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
            }
            return new string(stack.Reverse().ToArray());
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveDuplicates("abbaca");
        Console.WriteLine(ans);
    }
}