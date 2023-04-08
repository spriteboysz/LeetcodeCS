/*
 * Author: Deean
 * Date: 2023-04-08 19:18:40
 * FileName: 剑指 Offer II 056. 二叉搜索树中两个节点之和.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_II_056__二叉搜索树中两个节点之和 {
    public class Solution {
        HashSet<int> seen = new HashSet<int>();
        public bool FindTarget(TreeNode root, int k) {
            if (root == null) return false;
            if (seen.Contains(k - root.val)) {
                return true;
            }
            seen.Add(root.val);
            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTarget(new TreeNode("[8,6,10,5,7,9,11]"), 12);
        Console.WriteLine(ans);
    }
}