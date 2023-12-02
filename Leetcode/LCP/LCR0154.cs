/*
 * Author: Deean
 * Date: 2023-12-02 12:41:58
 * FileName: LCR0154.cs
 * Description: LCR 154. 复杂链表的复制
 */

using System;
using System.Collections.Generic;

namespace LCP;

public class LCR0154 {
    public class Solution {
        public class Node {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val) {
                val = _val;
                next = null;
                random = null;
            }
        }

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
        var s = new Solution();
        var ans = s.CopyRandomList(new Solution.Node(1));
        Console.WriteLine(ans);
    }
}