/*
 * Author: Deean
 * Date: 2023-06-02 23:34:00
 * FileName: P0024.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0024 {
    public class Solution {
        public ListNode SwapPairs(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = 0, n = nodes.Count; i + 2 <= n; i += 2) {
                var node = nodes[i];
                nodes[i] = nodes[i + 1];
                nodes[i + 1] = node;
            }
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,4]");
        var s = new Solution();
        var ans = s.SwapPairs(head);
        Console.WriteLine(ans);
    }
}