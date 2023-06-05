/*
 * Author: Deean
 * Date: 2023-06-04 22:18:11
 * FileName: P0979.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0979 {
    public class Solution {
        private int moves;

        private int dfs(TreeNode root) {
            if (root == null) return 0;
            int left = dfs(root.left);
            int right = dfs(root.right);
            moves += Math.Abs(left) + Math.Abs(right);
            return left + right + root.val - 1;
        }

        public int DistributeCoins(TreeNode root) {
            if (root == null) return 0;
            dfs(root);
            return moves;
        }
    }

    public static void Test() {
        var root = new TreeNode("[3,0,0]");
        var s = new Solution();
        var ans = s.DistributeCoins(root);
        Console.WriteLine(ans);
    }
}