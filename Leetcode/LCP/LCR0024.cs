/*
 * Author: Deean
 * Date: 2023-10-21 13:37:43
 * FileName: LCR0024.cs
 * Description:
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0024 {
    public class Solution {
        public ListNode ReverseList(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = nodes.Count - 1; i >= 1; i--) {
                nodes[i].next = nodes[i - 1];
            }
            nodes[0].next = null;
            return nodes[nodes.Count - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var head = new ListNode("[1,2,3,4,5]");
        var ans = s.ReverseList(head);
        Console.WriteLine(ans);
    }
}