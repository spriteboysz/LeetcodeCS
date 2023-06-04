/*
 * Author: Deean
 * Date: 2023-06-04 16:53:23
 * FileName: P0230.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0230 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            values.Add(root.val);
            dfs(root.right);
        }

        public int KthSmallest(TreeNode root, int k) {
            dfs(root);
            return values[k - 1];
        }
    }

    public static void Test() {
        var root = new TreeNode("[5,3,6,2,4,null,null,1]");
        var s = new Solution();
        var ans = s.KthSmallest(root, 3);
        Console.WriteLine(ans);
    }
}