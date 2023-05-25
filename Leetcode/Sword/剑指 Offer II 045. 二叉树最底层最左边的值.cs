/*
 * Author: Deean
 * Date: 2023-05-24 22:24:53
 * FileName: 剑指 Offer II 045. 二叉树最底层最左边的值.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_045__二叉树最底层最左边的值 {
    public class Solution {
        public int FindBottomLeftValue(TreeNode root) {
            int left = 0;
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