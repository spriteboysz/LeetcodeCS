/*
 * Author: Deean
 * Date: 2023-05-25 22:44:59
 * FileName: 剑指 Offer II 049. 从根节点到叶节点的路径数字之和.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_II_049__从根节点到叶节点的路径数字之和 {
    public class Solution {
        public int dfs(TreeNode root, int acc, int sum) {
            if (root == null) return 0;
            if (root.left == null && root.right == null) {
                sum = sum * 10 + root.val;
                acc = acc * 10 + sum;
                return acc;
            }
            sum = sum * 10 + root.val;
            return dfs(root.left, acc, sum) + dfs(root.right, acc, sum);
        }

        public int SumNumbers(TreeNode root) {
            return dfs(root, 0, 0);
        }
    }

    public static void Test() {
        var root = new TreeNode("[4,9,0,5,1]");
        var s = new Solution();
        var ans = s.SumNumbers(root);
        Console.WriteLine(ans);
    }
}