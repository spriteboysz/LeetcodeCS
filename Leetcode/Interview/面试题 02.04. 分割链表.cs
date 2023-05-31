/*
 * Author: Deean
 * Date: 2023-05-31 23:39:39
 * FileName: 面试题 02.04. 分割链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Interview;

public class 面试题_02_04__分割链表 {
    public class Solution {
        public ListNode Partition(ListNode head, int x) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            IList<ListNode> gt = new List<ListNode>();
            while (head != null) {
                if (head.val < x) {
                    nodes.Add(head);
                } else {
                    gt.Add(head);
                }
                head = head.next;
            }
            foreach (var node in gt) {
                nodes.Add(node);
            }
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].next = nodes[i + 1];
            }
            nodes.Last().next = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var head = new ListNode("[1,4,3,2,5,2]");
        var s = new Solution();
        var ans = s.Partition(head, 3);
        Console.WriteLine(ans);
    }
}