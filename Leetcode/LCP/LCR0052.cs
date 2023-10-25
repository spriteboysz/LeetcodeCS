/*
 * Author: Deean
 * Date: 2023-10-23 22:05:15
 * FileName: LCR0052.cs
 * Description: LCR 052. 递增顺序搜索树
 */

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace LCP;

public class LCR0052 {
    public class Solution {
        private IList<TreeNode> nodes = new List<TreeNode>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            nodes.Add(root);
            dfs(root.right);
        }

        public TreeNode IncreasingBST(TreeNode root) {
            if (root == null) return null;
            dfs(root);
            for (int i = 0, n = nodes.Count; i < n - 1; i++) {
                nodes[i].left = null;
                nodes[i].right = nodes[i + 1];
            }
            nodes.Last().left = null;
            nodes.Last().right = null;
            return nodes.First();
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IncreasingBST(new TreeNode("[5,3,6,2,4,null,8,1,null,null,null,7,9]"));
        Console.WriteLine(ans.ToString());
    }
}