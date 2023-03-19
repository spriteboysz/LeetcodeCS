/*
 * Author: Deean
 * Date: 2023-03-19 10:43:45
 * FileName: P2299.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P2299 {
    public class Solution {
        public bool StrongPasswordCheckerII(string password) {
            int n = password.Length;
            if (n < 8) return false;
            HashSet<char> specials = new HashSet<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
            bool hasLower = false, hasUpper = false, hasDigit = false, hasSpecial = false;
            for (int i = 0; i < n; i++) {
                if (i != n - 1 && password[i] == password[i + 1]) return false;
                char c = password[i];
                if (char.IsLower(c)) hasLower = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (specials.Contains(c)) hasSpecial = true;
            }
            return hasLower && hasUpper && hasDigit && hasSpecial;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.StrongPasswordCheckerII("IloveLe3tcode!");
        Console.WriteLine(ans);
    }
}