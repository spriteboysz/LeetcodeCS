/*
 * Author: Deean
 * Date: 2023-10-27 23:20:33
 * FileName: LCR0078.cs
 * Description: LCR 078. 合并 K 个升序链表
 */

using System;
using lib;

namespace LCP;

public class LCR0078 {
    public class Solution {
        public ListNode MergeKLists(ListNode[] lists) {
            if (lists.Length == 0) return null;
            for (int i = 1, n = lists.Length; i <= n; i *= 2) {
                var k = 0;
                while (k + i < n) {
                    var first = lists[k];
                    var second = lists[k + i];
                    lists[k] = Merge(first, second);
                    k += i + i;
                }
            }
            return lists[0];
        }

        ListNode Merge(ListNode first, ListNode second) {
            var dummyNode = new ListNode();
            var p = dummyNode;
            while (first != null && second != null) {
                if (first.val < second.val) {
                    p.next = first;
                    first = first.next;
                } else {
                    p.next = second;
                    second = second.next;
                }
                p = p.next;
            }
            p.next = first ?? second;
            return dummyNode.next;
        }
    }

    public static void Test() {
        var list1 = new ListNode("[1,4,5]");
        var list2 = new ListNode("[1,3,4]");
        var list3 = new ListNode("[2,6]");
        var s = new Solution();
        var ans = s.MergeKLists(new[] { list1, list2, list3 });
        Console.WriteLine(ans);
    }
}