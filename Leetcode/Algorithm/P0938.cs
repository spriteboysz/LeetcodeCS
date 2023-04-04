/*
 * Author: Deean
 * Date: 2023-04-03 23:47:07
 * FileName: P0938.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0938 {
    public class Solution {
        public int RangeSumBST(TreeNode root, int low, int high) {
            if (root == null) return 0;
            if (root.val > high) {
                return RangeSumBST(root.left, low, high);
            }
            if (root.val < low) {
                return RangeSumBST(root.right, low, high);
            }
            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RangeSumBST(new TreeNode("[10,5,15,3,7,null,18]"), 7, 15);
        Console.WriteLine(ans);
    }
}