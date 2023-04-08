/*
 * Author: Deean
 * Date: 2023-04-08 13:10:58
 * FileName: 剑指 Offer 06. 从尾到头打印链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Sword;

public class 剑指_Offer_06__从尾到头打印链表 {
    public class Solution {
        public int[] ReversePrint(ListNode head) {
            IList<int> values = new List<int>();
            while (head != null) {
                values.Add(head.val);
                head = head.next;
            }
            int[] nums = values.ToArray();
            Array.Reverse(nums);
            return nums;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ReversePrint(new ListNode("[1,3,2]"));
        Console.WriteLine(Arrays.ToString(ans));
    }
}