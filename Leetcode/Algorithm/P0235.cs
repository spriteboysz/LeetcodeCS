/*
 * Author: Deean
 * Date: 2023-06-04 16:57:15
 * FileName: P0235.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0235 {
    public class Solution {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            int maximum = Math.Max(p.val, q.val);
            int minimum = Math.Min(p.val, q.val);
            if (root.val > maximum) {
                return LowestCommonAncestor(root.left, p, q);
            }
            if (root.val < minimum) {
                return LowestCommonAncestor(root.right, p, q);
            }
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[6,2,8,0,4,7,9,null,null,3,5]");
        var p = new TreeNode(2);
        var q = new TreeNode(8);
        var s = new Solution();
        var ans = s.LowestCommonAncestor(root, p, q);
        Console.WriteLine(ans);
    }
}