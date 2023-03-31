/*
 * Author: Deean
 * Date: 2023-03-18 14:50:16
 * FileName: MainProc.cs
 * Description:
*/

using System;

namespace lib {
    public class MainProc {
        public static void Main() {
            Console.WriteLine("Hello common");
            int [][] grid = Arrays.To2DArray("[[0,0,0],[0,1,0],[1,1,1]]");
            foreach (var row in grid) {
                Console.WriteLine(Arrays.ToString(row));
            }
            ListNode head = new ListNode("[1,0,1]");
            Console.WriteLine(head.ToString());
        }
    }
}