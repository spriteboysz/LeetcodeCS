/*
 * Author: Deean
 * Date: 2023-04-09 10:44:15
 * FileName: 面试题 02.03. 删除中间节点.cs
 * Description:
*/

using lib;

namespace Interview; 

public class 面试题_02_03__删除中间节点 {
    public class Solution {
        public void DeleteNode(ListNode node) {
            node.val = node.next.val;
            node.next = node.next.next;
        } 
    }

    public static void Test() {
        var s = new Solution();
        s.DeleteNode(new ListNode("[4,5,1,9]"));
    }
}