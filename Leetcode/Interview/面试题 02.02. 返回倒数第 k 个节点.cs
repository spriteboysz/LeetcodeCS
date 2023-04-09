/*
 * Author: Deean
 * Date: 2023-04-09 10:41:22
 * FileName: 面试题 02.02. 返回倒数第 k 个节点.cs
 * Description:
*/

using System;
using lib;

namespace Interview;

public class 面试题_02_02__返回倒数第_k_个节点 {
    public class Solution {
        public int KthToLast(ListNode head, int k) {
            ListNode fast = head, slow = head;
            while (k-- > 0) {
                fast = fast.next;
            }
            while (fast != null) {
                slow = slow.next;
                fast = fast.next;
            }
            return slow.val;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KthToLast(new ListNode("[1,2,3,4,5]"), 2);
        Console.WriteLine(ans);
    }
}