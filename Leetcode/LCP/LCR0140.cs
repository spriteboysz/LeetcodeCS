/*
 * Author: Deean
 * Date: 2023-11-22 23:01:29
 * FileName: LCR0140.cs
 * Description: LCR 140. 训练计划 II
 */

using System;
using lib;

namespace LCP;

public class LCR0140 {
    public class Solution {
        public ListNode TrainingPlan(ListNode head, int cnt) {
            ListNode fast = head, slow = head;
            while (cnt-- > 0) {
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
        var ans = s.TrainingPlan(new ListNode("[2,4,7,8]"), 1);
        Console.WriteLine(ans);
    }
}