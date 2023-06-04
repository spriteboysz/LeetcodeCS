/*
 * Author: Deean
 * Date: 2023-06-04 16:48:46
 * FileName: P0222.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0222 {
    public class Solution {
        private int cnt;

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            cnt++;
            dfs(root.right);
        }

        public int CountNodes(TreeNode root) {
            if (root == null) return 0;
            dfs(root);
            return cnt;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,4,5,6]");
        var s = new Solution();
        var ans = s.CountNodes(root);
        Console.WriteLine(ans);
    }
}