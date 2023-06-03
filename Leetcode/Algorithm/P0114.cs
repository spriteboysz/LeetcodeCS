/*
 * Author: Deean
 * Date: 2023-06-02 22:56:14
 * FileName: P0114.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0114 {
    public class Solution {
        private IList<TreeNode> nodes;

        private void dfs(TreeNode root) {
            if (root == null) return;
            nodes.Add(root);
            dfs(root.left);
            dfs(root.right);
        }

        public void Flatten(TreeNode root) {
            if (root == null) return;
            nodes = new List<TreeNode>();
            dfs(root);
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].left = null;
                nodes[i].right = nodes[i + 1];
            }
            nodes.Last().left = null;
            nodes.Last().right = null;
            Console.WriteLine(nodes.First());
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,5,3,4,null,6]");
        var s = new Solution();
        s.Flatten(root);
    }
}