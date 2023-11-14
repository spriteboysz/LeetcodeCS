/*
 * Author: Deean
 * Date: 2023-11-13 22:57:47
 * FileName: LCR0123.cs
 * Description: LCR 123. 图书整理 I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0123 {
    public class Solution {
        public int[] ReverseBookList(ListNode head) {
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
        var ans = s.ReverseBookList(new ListNode("[3,6,4,1]"));
        Console.WriteLine(ans);
    }
}