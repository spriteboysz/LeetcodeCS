/*
 * Author: Deean
 * Date: 2023-04-04 13:11:51
 * FileName: P0653.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0653 {
    public class Solution {
        HashSet<int> set = new HashSet<int>();

        public bool FindTarget(TreeNode root, int k) {
            if (root == null) return false;
            if (set.Contains(k - root.val)) {
                return true;
            }
            set.Add(root.val);
            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTarget(new TreeNode("[5,3,6,2,4,null,7]"), 9);
        Console.WriteLine(ans);
    }
}