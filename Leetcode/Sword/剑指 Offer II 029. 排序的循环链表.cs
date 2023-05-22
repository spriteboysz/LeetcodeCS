/*
 * Author: Deean
 * Date: 2023-05-21 22:57:40
 * FileName: 剑指 Offer II 029. 排序的循环链表.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

using Node = ListNode;

public class 剑指_Offer_II_029__排序的循环链表 {
    public class Solution {
        public Node Insert(Node head, int insertVal) {
            Node node = new ListNode(insertVal);
            if (head == null) {
                node.next = node;
                return node;
            }
            if (head.next == head) {
                head.next = node;
                node.next = head;
                return head;
            }
            Node cur = head, next = head.next;
            while (next != head) {
                if (insertVal >= cur.val && insertVal <= next.val) {
                    break;
                }
                if (cur.val > next.val) {
                    if (insertVal > cur.val || insertVal < next.val) {
                        break;
                    }
                }
                cur = cur.next;
                next = next.next;
            }
            cur.next = node;
            node.next = next;
            return head;
        }
    }

    public static void Test() {
        var s = new Solution();
        Node head = new ListNode("[3,4,1]");
        var ans = s.Insert(head, 2);
        Console.WriteLine(ans);
    }
}