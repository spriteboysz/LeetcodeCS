/*
 * Author: Deean
 * Date: 2023-05-25 23:56:26
 * FileName: P0538.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0538 {
    public class Solution {
        public int acc;

        public void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.right);
            root.val += acc;
            acc = root.val;
            dfs(root.left);
        }

        public TreeNode ConvertBST(TreeNode root) {
            if (root == null) return null;
            dfs(root);
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]");
        var s = new Solution();
        var ans = s.ConvertBST(root);
        Console.WriteLine(ans);
    }
}