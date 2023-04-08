/*
 * Author: Deean
 * Date: 2023-04-08 14:20:36
 * FileName: 剑指 Offer 25. 合并两个排序的链表.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_25__合并两个排序的链表 {
    public class Solution {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val) {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MergeTwoLists(new ListNode("[1,2,4]"), new ListNode("[1,3,4]"));
        Console.WriteLine(ans);
    }
}