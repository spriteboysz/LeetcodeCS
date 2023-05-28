/*
 * Author: Deean
 * Date: 2023-05-28 11:58:28
 * FileName: P0023.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0023 {
    public class Solution {
        private ListNode Process(ListNode first, ListNode second) {
            var dummy = new ListNode();
            var p = dummy;
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
            p.next = first == null ? second : first;
            return dummy.next;
        }

        public ListNode MergeKLists(ListNode[] lists) {
            if (lists.Length == 0) return null;
            for (int i = 1, n = lists.Length; i <= n; i *= 2) {
                int k = 0;
                while (i + k < n) {
                    var first = lists[k];
                    var second = lists[k + i];
                    lists[k] = Process(first, second);
                    k += i + i;
                }
            }
            return lists[0];
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