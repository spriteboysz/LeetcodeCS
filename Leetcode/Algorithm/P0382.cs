/*
 * Author: Deean
 * Date: 2023-06-01 23:50:18
 * FileName: P0382.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0382 {
    public class Solution {
        private IList<int> val;
        private Random random;

        public Solution(ListNode head) {
            val = new List<int>();
            while (head != null) {
                val.Add(head.val);
                head = head.next;
            }
        }

        public int GetRandom() {
            random = new Random();
            return val[random.Next(val.Count)];
        }
    }

    public static void Test() {
        var head = new ListNode("[1,2,3]");
        var obj = new Solution(head);
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
        Console.WriteLine(obj.GetRandom());
    }
}