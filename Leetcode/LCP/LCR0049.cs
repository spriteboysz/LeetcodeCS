/*
 * Author: Deean
 * Date: 2023-10-23 21:58:57
 * FileName: LCR0049.cs
 * Description: LCR 049. 求根节点到叶节点数字之和
 */

using System;
using lib;

namespace LCP;

public class LCR0049 {
    public class Solution {
        public int SumNumbers(TreeNode root) {
            if (root == null) return 0;
            return dfs(root, 0);
        }

        private int dfs(TreeNode root, int sum) {
            if (root == null) return 0;
            sum = sum * 10 + root.val;
            if (root.left == null && root.right == null) {
                return sum;
            }
            return dfs(root.left, sum) + dfs(root.right, sum);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumNumbers(new TreeNode("[1,2,3]"));
        Console.WriteLine(ans);
    }
}