/*
 * Author: Deean
 * Date: 2023-04-02 15:35:55
 * FileName: P1021.cs
 * Description:
*/

using System;
using System.Text;

namespace Algorithm; 

public class P1021 {
    public class Solution {
        public string RemoveOuterParentheses(string s) {
            StringBuilder ss = new StringBuilder();
            StringBuilder sub = new StringBuilder();
            int balance = 0;
            foreach (var c in s) {
                if (c == '(') {
                    balance++;
                    sub.Append('(');
                } else {
                    balance--;
                    sub.Append(')');
                }
                if (balance == 0) {
                    ss.Append(sub.ToString().Substring(1, sub.Length - 2));
                    sub.Remove(0, sub.Length);
                }
            }
            return ss.ToString();
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveOuterParentheses("(()())(())(()(()))");
        Console.WriteLine(ans);
    }
}