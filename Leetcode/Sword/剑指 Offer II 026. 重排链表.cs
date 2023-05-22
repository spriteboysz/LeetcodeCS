/*
 * Author: Deean
 * Date: 2023-05-21 22:28:52
 * FileName: 剑指 Offer II 026. 重排链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_II_026__重排链表 {
    public class Solution {
        public void ReorderList(ListNode head) {
            IList<ListNode> nodes1 = new List<ListNode>();
            ListNode cur = head;
            while (cur != null) {
                nodes1.Add(cur);
                cur = cur.next;
            }
            IList<ListNode> nodes2 = new List<ListNode>();
            for (int i = 0, n = nodes1.Count; i < (n + 1) / 2; i++) {
                nodes2.Add(nodes1[i]);
                nodes2.Add(nodes1[n - 1 - i]);
            }
            for (int i = 0, n = nodes1.Count; i < n - 1; i++) {
                nodes2[i].next = nodes2[i + 1];
            }
            nodes2.Last().next = null;
            Console.WriteLine(head.ToString());
        }
    }

    public static void Test() {
        var s = new Solution();
        var head = new ListNode("[1,2,3,4,5]");
        s.ReorderList(head);
    }
}