/*
 * Author: Deean
 * Date: 2023-04-08 17:45:01
 * FileName: 剑指 Offer II 027. 回文链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_027__回文链表 {
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
        var ans = s.IsPalindrome(new ListNode("[1,2,3,3,2,1]"));
        Console.WriteLine(ans);
    }
}