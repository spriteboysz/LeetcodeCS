/*
 * Author: Deean
 * Date: 2023-10-21 14:43:59
 * FileName: LCR0027.cs
 * Description: LCR 027. 回文链表
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP; 

public class LCR0027 {
    public class Solution {
        public bool IsPalindrome(ListNode head) {
            if (head == null) return true;
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
        var head = new ListNode("[1,2,3,3,2,1]");
        var ans = s.IsPalindrome(head);
        Console.WriteLine(ans);
    }
}