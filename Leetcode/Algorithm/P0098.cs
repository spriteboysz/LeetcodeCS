/*
 * Author: Deean
 * Date: 2023-06-03 21:22:38
 * FileName: P0098.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0098 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        public bool IsValidBST(TreeNode root) {
            if (root == null) return true;
            dfs(root);
            for (int i = 0, n = values.Count; i < n - 1; i++) {
                if (values[i] >= values[i + 1]) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var root = new TreeNode("[2,1,3]");
        var s = new Solution();
        var ans = s.IsValidBST(root);
        Console.WriteLine(ans);
    }
}