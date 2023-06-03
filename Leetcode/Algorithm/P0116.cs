/*
 * Author: Deean
 * Date: 2023-06-03 16:08:58
 * FileName: P0116.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

using Node = TreeNode;

public class P0116 {
    public class Solution {
        public Node Connect(Node root) {
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (i < n - 1) {
                        node.next = queue.Peek();
                    }
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }

    public static void Test() {
        var root = new Node("[1,2,3,4,5,6,7]");
        var s = new Solution();
        var ans = s.Connect(root);
        Console.WriteLine(ans);
    }
}