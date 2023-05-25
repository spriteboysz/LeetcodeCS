/*
 * Author: Deean
 * Date: 2023-05-25 23:51:54
 * FileName: 剑指 Offer II 054. 所有大于等于节点的值之和.cs
 * Description:
*/

using System;
using lib;

namespace Sword;

public class 剑指_Offer_II_054__所有大于等于节点的值之和 {
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
        var root = new TreeNode("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]");
        var s = new Solution();
        var ans = s.ConvertBST(root);
        Console.WriteLine(ans);
    }
}