/*
 * Author: Deean
 * Date: 2023-04-04 15:37:50
 * FileName: P0700.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0700 {
    public class Solution {
        public TreeNode SearchBST(TreeNode root, int val) {
            if (root == null) return null;
            if (root.val > val) {
                return SearchBST(root.left, val);
            }
            if (root.val < val) {
                return SearchBST(root.right, val);
            }
            return root;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SearchBST(new TreeNode("[4,2,7,1,3]"), 2);
        Console.WriteLine(ans.ToString());
    }
}