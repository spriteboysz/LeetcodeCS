﻿/*
 * Author: Deean
 * Date: 2023-10-23 22:33:42
 * FileName: LCR0056.cs
 * Description: LCR 056. 两数之和 IV - 输入二叉搜索树
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0056 {
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
        var ans = s.FindTarget(new TreeNode("[8,6,10,5,7,9,11]"), 18);
        Console.WriteLine(ans);
    }
}