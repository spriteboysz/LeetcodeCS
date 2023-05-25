/*
 * Author: Deean
 * Date: 2023-05-25 23:39:59
 * FileName: P0124.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0124 {
    public class Solution {
        private int maximum;

        public int dfs(TreeNode root) {
            if (root == null) return 0;
            var left = Math.Max(0, dfs(root.left));
            var right = Math.Max(0, dfs(root.right));
            maximum = Math.Max(maximum, left + right + root.val);
            return Math.Max(left, right) + root.val;
        }

        public int MaxPathSum(TreeNode root) {
            if (root == null) return 0;
            maximum = Int32.MinValue;
            dfs(root);
            return maximum;
        }
    }

    public static void Test() {
        var root = new TreeNode("[-10,9,20,null,null,15,7]");
        var s = new Solution();
        var ans = s.MaxPathSum(root);
        Console.WriteLine(ans);
    }
}