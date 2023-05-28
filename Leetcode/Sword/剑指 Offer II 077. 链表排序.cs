/*
 * Author: Deean
 * Date: 2023-05-27 22:57:45
 * FileName: 剑指 Offer II 077. 链表排序.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_II_077__链表排序 {
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
        var head = new ListNode("[4,2,1,3]");
        var s = new Solution();
        var ans = s.SortList(head);
        Console.WriteLine(ans);
    }
}