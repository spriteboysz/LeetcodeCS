/*
 * Author: Deean
 * Date: 2023-04-07 20:46:56
 * FileName: P0234.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0234 {
    public class Solution {
        public bool IsPalindrome(ListNode head) {
            IList<int> values = new List<int>();
            while (head != null) {
                values.Add(head.val);
                head = head.next;
            }
            for (int i = 0, n = values.Count; i < n / 2; i++) {
                if (values[i] != values[n - 1 - i]) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsPalindrome(new ListNode("[1,2,2,1]"));
        Console.WriteLine(ans);
    }
}