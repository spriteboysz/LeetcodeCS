/*
 * Author: Deean
 * Date: 2023-06-03 16:43:23
 * FileName: P0817.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm; 

public class P0817 {
    public class Solution {
        public int NumComponents(ListNode head, int[] nums) {
            HashSet<int> numsSet = new HashSet<int>();
            foreach (int num in nums) {
                numsSet.Add(num);
            }
            bool flag = false;
            int cnt = 0;
            while (head != null) {
                if (numsSet.Contains(head.val)) {
                    if (!flag) {
                        flag = true;
                        cnt++;
                    }
                } else {
                    flag = false;
                }
                head = head.next;
            }
            return cnt;
        } 
    }

    public static void Test() {
        var head = new ListNode("[0,1,2,3]");
        var s = new Solution();
        var ans = s.NumComponents(head, new[] { 0, 1, 3 });
        Console.WriteLine(ans);
    }
}