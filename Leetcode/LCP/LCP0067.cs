/*
 * Author: Deean
 * Date: 2023-06-04 20:28:34
 * FileName: LCP0067.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCP0067 {
    public class Solution {
        public TreeNode ExpandBinaryTree(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (node.left != null) {
                        queue.Enqueue(node.left);
                        node.left = new TreeNode(-1, node.left);
                    }
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                        node.right = new TreeNode(-1, null, node.right);
                    }
                }
            }
            
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[7,5,6]");
        var s = new Solution();
        var ans = s.ExpandBinaryTree(root);
        Console.WriteLine(ans);
    }
}