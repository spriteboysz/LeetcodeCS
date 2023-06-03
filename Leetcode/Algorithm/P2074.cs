/*
 * Author: Deean
 * Date: 2023-06-03 17:04:13
 * FileName: P2074.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P2074 {
    public class Solution {
        public ListNode ReverseEvenLengthGroups(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = 0, size = 0, n = nodes.Count; i < n; i += size) {
                size = Math.Min(++size, n - i);
                if (size % 2 == 1) continue;
                for (int j = 0; j < size / 2; j++) {
                    var node = nodes[i + j];
                    nodes[i + j] = nodes[i + size - j - 1];
                    nodes[i + size - j - 1] = node;
                }
            }
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[5,2,6,3,9,1,7,3,8,4]");
        var s = new Solution();
        var ans = s.ReverseEvenLengthGroups(head);
        Console.WriteLine(ans);
    }
}