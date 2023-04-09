/*
 * Author: Deean
 * Date: 2023-04-09 10:47:56
 * FileName: 面试题 02.06. 回文链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Interview;

public class 面试题_02_06__回文链表 {
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
        var ans = s.IsPalindrome(new ListNode("[1,2,2,1]"));
        Console.WriteLine(ans);
    }
}