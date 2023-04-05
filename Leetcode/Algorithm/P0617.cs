/*
 * Author: Deean
 * Date: 2023-04-05 19:10:45
 * FileName: P0617.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0617 {
    public class Solution {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            TreeNode merged = new TreeNode(root1.val + root2.val) {
                left = MergeTrees(root1.left, root2.left),
                right = MergeTrees(root1.right, root2.right)
            };
            return merged;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MergeTrees(new TreeNode("[1,3,2,5]"), new TreeNode("[2,1,3,null,4,null,7]"));
        Console.WriteLine(ans);
    }
}