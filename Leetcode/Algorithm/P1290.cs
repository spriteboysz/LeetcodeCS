/*
 * Author: Deean
 * Date: 2023-03-31 22:37:27
 * FileName: P1290.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1290 {
    public class Solution {
        public int GetDecimalValue(ListNode head) {
            int num = 0;
            while (head != null) {
                num = num * 2 + head.val;
                head = head.next;
            }
            return num;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GetDecimalValue(new ListNode("[1,0,0,1,0,0,1,1,1,0,0,0,0,0,0]"));
        Console.WriteLine(ans);
    }
}