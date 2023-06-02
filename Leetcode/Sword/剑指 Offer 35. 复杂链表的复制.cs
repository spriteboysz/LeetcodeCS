/*
 * Author: Deean
 * Date: 2023-06-01 22:53:04
 * FileName: 剑指 Offer 35. 复杂链表的复制.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword; 
using Node = ListNode;

public class 剑指_Offer_35__复杂链表的复制 {
    public class Solution {
        public Node CopyRandomList(Node head) {
            if (head == null) return null;
            IDictionary<Node, Node> dict = new Dictionary<Node, Node>();
            Node cur = head;
            while (cur != null) {
                dict.Add(cur, new Node(cur.val));
                cur = cur.next;
            }
            cur = head;
            while (cur != null) {
                if (cur.next != null) {
                    dict[cur].next = dict[cur.next];
                }
                if (cur.random != null) {
                    dict[cur].random = dict[cur.random];
                }
                cur = cur.next;
            }
            return dict[head];
        } 
    }

    public static void Test() {
        Node head = new Node("[[7,null],[13,0],[11,4],[10,2],[1,0]]");
        var s = new Solution();
        var ans = s.CopyRandomList(head);
        Console.WriteLine(ans);
    }
}