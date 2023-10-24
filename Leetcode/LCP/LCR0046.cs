/*
 * Author: Deean
 * Date: 2023-10-23 21:43:49
 * FileName: LCR0046.cs
 * Description: LCR 046. 二叉树的右视图
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0046 {
    public class Solution {
        public IList<int> RightSideView(TreeNode root) {
            IList<int> right = new List<int>();
            if (root == null) return right;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int level = queue.First().val;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    level = node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                right.Add(level);
            }
            return right;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RightSideView(new TreeNode("[1,2,3,null,5,null,4]"));
        Console.WriteLine(Arrays.ToString(ans));
    }
}