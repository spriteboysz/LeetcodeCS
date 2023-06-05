/*
 * Author: Deean
 * Date: 2023-06-04 22:26:20
 * FileName: P2415.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P2415 {
    public class Solution {
        public TreeNode ReverseOddLevels(TreeNode root) {
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;
            while (queue.Count != 0) {
                Stack<int> values = new Stack<int>();
                IList<TreeNode> nodes = new List<TreeNode>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (level % 2 == 1) {
                        values.Push(node.val);
                        nodes.Add(node);
                    }
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (level % 2 == 1) {
                    foreach (var node in nodes) {
                        node.val = values.Pop();
                    }
                }
                level += 1;
            }
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[2,3,5,8,13,21,34]");
        var s = new Solution();
        var ans = s.ReverseOddLevels(root);
        Console.WriteLine(ans);
    }
}