/*
 * Author: Deean
 * Date: 2023-04-08 17:40:32
 * FileName: 剑指 Offer II 024. 反转链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword; 

public class 剑指_Offer_II_024__反转链表 {
    public class Solution {
        public ListNode ReverseList(ListNode head) {
            if (head == null) return null;
            IList<ListNode> nodes = new List<ListNode>();
            while (head != null) {
                nodes.Add(head);
                head = head.next;
            }
            for (int i = nodes.Count - 1; i >= 1; i--) {
                nodes[i].next = nodes[i - 1];
            }
            nodes[0].next = null;
            return nodes[nodes.Count - 1];
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReverseList(new ListNode("[1,2,3,4,5]"));
        Console.WriteLine(ans);
    }
}