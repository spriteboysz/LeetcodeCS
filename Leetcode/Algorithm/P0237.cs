/*
 * Author: Deean
 * Date: 2023-06-02 22:35:30
 * FileName: P0237.cs
 * Description:
*/

using lib;

namespace Algorithm; 

public class P0237 {
    public class Solution {
        public void DeleteNode(ListNode node) {
            node.val = node.next.val;
            node.next = node.next.next;
        } 
    }

    public static void Test() {
        var node = new ListNode(5);
        var s = new Solution();
        s.DeleteNode(node);
    }
}