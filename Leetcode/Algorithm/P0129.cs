/*
 * Author: Deean
 * Date: 2023-05-25 22:55:32
 * FileName: P0129.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0129 {
    public class Solution {
        public int dfs(TreeNode root, int acc, int sum) {
            if (root == null) return 0;
            if (root.left == null && root.right == null) {
                acc = acc * 10 + root.val;
                sum = sum * 10 + acc;
                return sum;
            }
            acc = acc * 10 + root.val;
            return dfs(root.left, acc, sum) + dfs(root.right, acc, sum);
        }

        public int SumNumbers(TreeNode root) {
            return dfs(root, 0, 0);
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3]");
        var s = new Solution();
        var ans = s.SumNumbers(root);
        Console.WriteLine(ans);
    }
}