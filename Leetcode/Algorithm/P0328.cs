/*
 * Author: Deean
 * Date: 2023-06-02 21:51:24
 * FileName: P0328.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0328 {
    public class Solution {
        public ListNode OddEvenList(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            IList<ListNode> even = new List<ListNode>();
            for (int i = 0; head != null; i++) {
                if (i % 2 == 0) {
                    nodes.Add(head);
                } else {
                    even.Add(head);
                }
                head = head.next;
            }
            for (int i = 0, n = even.Count; i < n; i++) {
                nodes.Add(even[i]);
            }
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,4,5]");
        var s = new Solution();
        var ans = s.OddEvenList(head);
        Console.WriteLine(ans);
    }
}