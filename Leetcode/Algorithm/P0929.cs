/*
 * Author: Deean
 * Date: 2023-04-03 23:36:24
 * FileName: P0929.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0929 {
    public class Solution {
        public int NumUniqueEmails(string[] emails) {
            HashSet<string> set = new HashSet<string>();
            foreach (var email in emails) {
                string local = email.Split('@')[0];
                string domain = email.Split('@')[1];
                local = local.Replace(".", "");
                local = local.Split('+')[0];
                set.Add(local + '@' + domain);
            }
            return set.Count;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.NumUniqueEmails(new[] {
            "test.email+alex@leetcode.com",
            "test.e.mail+bob.cathy@leetcode.com",
            "testemail+david@lee.tcode.com"
        });
        Console.WriteLine(ans);
    }
}