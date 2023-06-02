/*
 * Author: Deean
 * Date: 2023-06-02 22:29:11
 * FileName: P1669.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1669 {
    public class Solution {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
            ListNode pre1 = list1;
            for (int i = 0; i < a - 1; i++) {
                pre1 = pre1.next;
            }
            ListNode pre2 = pre1;
            for (int i = 0; i < b - a + 2; i++) {
                pre2 = pre2.next;
            }
            pre1.next = list2;
            while (list2.next != null) {
                list2 = list2.next;
            }
            list2.next = pre2;
            return list1;
        }
    }

    public static void Test() {
        var list1 = new ListNode("[0,1,2,3,4,5]");
        var list2 = new ListNode("[1000000,1000001,1000002]");
        var s = new Solution();
        var ans = s.MergeInBetween(list1, 3, 4, list2);
        Console.WriteLine(ans);
    }
}