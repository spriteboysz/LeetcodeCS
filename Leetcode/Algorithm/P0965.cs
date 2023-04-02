/*
 * Author: Deean
 * Date: 2023-04-02 19:45:34
 * FileName: P0965.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0965 {
    public class Solution {
        public bool IsUnivalTree(TreeNode root) {
            if (root == null) return true;
            if (root.left != null) {
                if (root.val != root.left.val || !IsUnivalTree(root.left)) {
                    return false;
                }
            }
            if (root.right != null) {
                if (root.val != root.right.val || !IsUnivalTree(root.right)) {
                    return false;
                }
            }
            return true;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsUnivalTree(new TreeNode("[1,1,1,1,1,null,1]"));
        Console.WriteLine(ans);
    }
}