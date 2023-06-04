/*
 * Author: Deean
 * Date: 2023-06-04 20:49:45
 * FileName: P1382.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P1382 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        private TreeNode create(int left, int right) {
            if (left >= right) return null;
            int mid = (left + right) / 2;
            var root = new TreeNode(values[mid]) {
                left = create(left, mid),
                right = create(mid + 1, right)
            };
            return root;
        }

        public TreeNode BalanceBST(TreeNode root) {
            if (root == null) return null;
            dfs(root);
            return create(0, values.Count);
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,null,2,null,3,null,4,null,null]");
        var s = new Solution();
        var ans = s.BalanceBST(root);
        Console.WriteLine(ans);
    }
}