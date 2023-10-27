/*
 * Author: Deean
 * Date: 2023-10-23 22:31:35
 * FileName: LCR0054.cs
 * Description: LCR 054. 把二叉搜索树转换为累加树
 */

using System;
using lib;

namespace LCP;

public class LCR0054 {
    public class Solution {
        private int acc;

        public void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.right);
            root.val += acc;
            acc = root.val;
            dfs(root.left);
        }

        public TreeNode ConvertBST(TreeNode root) {
            dfs(root);
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConvertBST(new TreeNode("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]"));
        Console.WriteLine(ans);
    }
}