/*
 * Author: Deean
 * Date: 2023-06-02 22:09:26
 * FileName: P0092.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0092 {
    public class Solution {
        public ListNode ReverseBetween(ListNode head, int left, int right) {
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = left - 1; i <= (right + left - 2) / 2; i++) {
                var node = nodes[i];
                nodes[i] = nodes[right + left - i - 2];
                nodes[right + left - i - 2] = node;
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
        var ans = s.ReverseBetween(head, 2, 4);
        Console.WriteLine(ans);
    }
}