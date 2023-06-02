/*
 * Author: Deean
 * Date: 2023-06-02 22:42:11
 * FileName: P1721.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P1721 {
    public class Solution {
        public ListNode SwapNodes(ListNode head, int k) {
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            int n = nodes.Count;
            ListNode node = nodes[k - 1];
            nodes[k - 1] = nodes[n - k];
            nodes[n - k] = node;
            for (int i = 0; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3,4,5]");
        var s = new Solution();
        var ans = s.SwapNodes(head, 2);
        Console.WriteLine(ans);
    }
}