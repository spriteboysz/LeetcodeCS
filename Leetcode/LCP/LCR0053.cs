/*
 * Author: Deean
 * Date: 2023-10-23 22:22:29
 * FileName: LCR0053.cs
 * Description: LCR 053. 二叉搜索树中的中序后继
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0053 {
    public class Solution {
        private IList<TreeNode> nodes = new List<TreeNode>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            nodes.Add(root);
            dfs(root.right);
        }

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
            if (root == null) return null;
            dfs(root);
            for (var i = 0; i < nodes.Count - 1; i++) {
                if (nodes[i].val == p.val) {
                    return nodes[i + 1];
                }
            }
            return null;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.InorderSuccessor(new TreeNode("[5,3,6,2,4,null,null,1]"), new TreeNode("[0]"));
        Console.WriteLine(ans.ToString());
    }
}