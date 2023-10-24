/*
 * Author: Deean
 * Date: 2023-10-23 21:54:50
 * FileName: LCR0047.cs
 * Description: LCR 047. 二叉树剪枝
 */

using System;
using lib;

namespace LCP;

public class LCR0047 {
    public class Solution {
        public TreeNode PruneTree(TreeNode root) {
            if (root == null) return null;
            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if (root.val == 0 && root.left == null && root.right == null) {
                return null;
            }
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.PruneTree(new TreeNode("[1,0,1,0,0,0,1]"));
        Console.WriteLine(ans.ToString());
    }
}