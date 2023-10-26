/*
 * Author: Deean
 * Date: 2023-10-23 21:23:30
 * FileName: LCR0036.cs
 * Description: LCR 036. 逆波兰表达式求值
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0036 {
    public class Solution {
        public int EvalRPN(string[] tokens) {
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens) {
                if ((token.Length > 1 && token[0] == '-') || (token[0] >= '0' && token[0] <= '9')) {
                    stack.Push(Int32.Parse(token));
                } else {
                    int a = stack.Pop(), b = stack.Pop();
                    switch (token) {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(b - a);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(b / a);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.EvalRPN(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" });
        Console.WriteLine(ans);
    }
}