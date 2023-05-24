/*
 * Author: Deean
 * Date: 2023-05-24 22:29:41
 * FileName: P0513.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0513 {
    public class Solution {
        public int FindBottomLeftValue(TreeNode root) {
            int left = 0;
            if (root == null) return left;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (i == 0) left = node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return left;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,4,null,5,6,null,null,7]");
        var s = new Solution();
        var ans = s.FindBottomLeftValue(root);
        Console.WriteLine(ans);
    }
}