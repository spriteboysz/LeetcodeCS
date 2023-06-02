/*
 * Author: Deean
 * Date: 2023-06-01 23:09:09
 * FileName: P0061.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0061 {
    public class Solution {
        public ListNode RotateRight(ListNode head, int k) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            int n = nodes.Count;
            Console.WriteLine(n);
            Console.WriteLine(k);
            if (n == k) return nodes.First();
            k %= n;
            if (k == 0) return nodes.First();
            nodes.Last().next = nodes.First();
            nodes[n - k - 1].next = null;
            return nodes[n - k];
        }
    }

    public static void Test() {
        var head = new ListNode("[1]");
        var s = new Solution();
        var ans = s.RotateRight(head, 1);
        Console.WriteLine(ans);
    }
}