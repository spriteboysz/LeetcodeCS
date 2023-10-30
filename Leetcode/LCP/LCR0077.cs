/*
 * Author: Deean
 * Date: 2023-10-26 22:40:57
 * FileName: LCR0077.cs
 * Description: LCR 077. 排序链表
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0077 {
    public class Solution {
        public ListNode SortList(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            ListNode[] nodes2 = nodes.ToArray();
            Array.Sort(nodes2, (n1, n2) => n1.val - n2.val);
            for (int i = 0, n = nodes2.Length; i < n - 1; i++) {
                nodes2[i].next = nodes2[i + 1];
            }
            nodes2.Last().next = null;
            return nodes2.First();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SortList(new ListNode("[5,4,3,2,1]"));
        Console.WriteLine(ans);
    }
}