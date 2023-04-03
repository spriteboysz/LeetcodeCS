/*
 * Author: Deean
 * Date: 2023-04-03 22:44:32
 * FileName: P0897.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0897 {
    public class Solution {
        public void dfs(TreeNode root, List<TreeNode> nodes) {
            if (root == null) return;
            dfs(root.left, nodes);
            nodes.Add(root);
            dfs(root.right, nodes);
        }

        public TreeNode IncreasingBST(TreeNode root) {
            List<TreeNode> nodes = new List<TreeNode>();
            dfs(root, nodes);
            for (int i = 0; i < nodes.Count - 1; i++) {
                nodes[i].left = null;
                nodes[i].right = nodes[i + 1];
            }
            nodes[nodes.Count - 1].left = null;
            nodes[nodes.Count - 1].right = null;
            return nodes[0];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IncreasingBST(new TreeNode("[5,3,6,2,4,null,8,1,null,null,null,7,9]"));
        Console.WriteLine(ans.ToString());
    }
}