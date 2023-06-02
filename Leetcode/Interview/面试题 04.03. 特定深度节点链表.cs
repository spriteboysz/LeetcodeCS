/*
 * Author: Deean
 * Date: 2023-06-02 21:58:54
 * FileName: 面试题 04.03. 特定深度节点链表.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Interview;

public class 面试题_04_03__特定深度节点链表 {
    public class Solution {
        public ListNode[] ListOfDepth(TreeNode tree) {
            IList<ListNode> levels = new List<ListNode>();
            if (tree == null) return levels.ToArray();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            while (queue.Count != 0) {
                ListNode dummy = new ListNode();
                ListNode cur = dummy;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    var next = new ListNode(node.val);
                    cur.next = next;
                    cur = cur.next;
                    if (node.left != null) {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                    }
                }
                levels.Add(dummy.next);
            }
            return levels.ToArray();
        }
    }

    public static void Test() {
        var tree = new TreeNode("[1,2,3,4,5,null,7,8]");
        var s = new Solution();
        var ans = s.ListOfDepth(tree);
        Console.WriteLine(ans);
    }
}