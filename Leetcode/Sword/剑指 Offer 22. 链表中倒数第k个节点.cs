/*
 * Author: Deean
 * Date: 2023-04-08 13:49:15
 * FileName: 剑指 Offer 22. 链表中倒数第k个节点.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_22__链表中倒数第k个节点 {
    public class Solution {
        public ListNode GetKthFromEnd(ListNode head, int k) {
            ListNode fast = head, slow = head;
            while (k-- > 0) {
                fast = fast.next;
            }
            while (fast != null) {
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetKthFromEnd(new ListNode("[1,2,3,4,5]"), 2);
        Console.WriteLine(ans);
    }
}