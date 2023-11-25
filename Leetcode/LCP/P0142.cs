/*
 * Author: Deean
 * Date: 2023-11-24 22:22:53
 * FileName: P0142.cs
 * Description: LCR 142. 训练计划 IV
 */

using System;
using lib;

namespace LCP;

public class P0142 {
    public class Solution {
        public ListNode TrainningPlan(ListNode l1, ListNode l2) {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val) {
                l1.next = TrainningPlan(l1.next, l2);
                return l1;
            }
            l2.next = TrainningPlan(l1, l2.next);
            return l2;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.TrainningPlan(new ListNode("[1,2,4]"), new ListNode("[1,3,4]"));
        Console.WriteLine(ans);
    }
}