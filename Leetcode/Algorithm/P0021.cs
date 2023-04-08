/*
 * Author: Deean
 * Date: 2023-04-08 11:30:58
 * FileName: P0021.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0021 {
    public class Solution {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            if (list1 == null) {
                return list2;
            }
            if (list2 == null) {
                return list1;
            }
            if (list1.val < list2.val) {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MergeTwoLists(new ListNode("[1,2,4]"), new ListNode("[1,3,4]"));
        Console.WriteLine(ans);
    }
}