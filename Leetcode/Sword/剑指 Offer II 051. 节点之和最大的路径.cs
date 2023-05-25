/*
 * Author: Deean
 * Date: 2023-05-25 23:35:04
 * FileName: 剑指 Offer II 051. 节点之和最大的路径.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_II_051__节点之和最大的路径 {
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
            maximum = Int32.MinValue;
            dfs(root);
            return maximum;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3]");
        var s = new Solution();
        var ans = s.MaxPathSum(root);
        Console.WriteLine(ans);
    }
}