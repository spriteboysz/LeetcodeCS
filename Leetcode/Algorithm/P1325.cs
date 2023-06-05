/*
 * Author: Deean
 * Date: 2023-06-04 21:58:03
 * FileName: P1325.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P1325 {
    public class Solution {
        public TreeNode RemoveLeafNodes(TreeNode root, int target) {
            if (root == null) return null;
            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);
            if (root.left == null && root.right == null && root.val == target) {
                return null;
            }
            return root;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,2,null,2,4]");
        var s = new Solution();
        var ans = s.RemoveLeafNodes(root, 2);
        Console.WriteLine(ans);
    }
}