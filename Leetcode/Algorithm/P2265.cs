/*
 * Author: Deean
 * Date: 2023-06-05 23:19:31
 * FileName: P2265.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P2265 {
    public class Solution {
        private int cnt;

        private int[] dfs(TreeNode root) {
            if (root == null) return new int[2];
            int[] left = dfs(root.left), right = dfs(root.right);
            int sum = root.val + left[0] + right[0];
            int num = 1 + left[1] + right[1];
            if (root.val == sum / num) {
                cnt++;
            }
            return new[] { sum, num };
        }

        public int AverageOfSubtree(TreeNode root) {
            dfs(root);
            return cnt;
        }
    }

    public static void Test() {
        var root = new TreeNode("[4,8,5,0,1,null,6]");
        var s = new Solution();
        var ans = s.AverageOfSubtree(root);
        Console.WriteLine(ans);
    }
}