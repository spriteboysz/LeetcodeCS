﻿/*
 * Author: Deean
 * Date: 2023-05-25 23:08:13
 * FileName: P0437.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0437 {
    public class Solution {
        public int Process(TreeNode root, long target) {
            if (root == null) return 0;
            int cnt = 0;
            if (root.val == target) cnt++;
            cnt += Process(root.left, target - root.val);
            cnt += Process(root.right, target - root.val);
            return cnt;
        }

        public int PathSum(TreeNode root, int targetSum) {
            if (root == null) return 0;
            int cnt = Process(root, targetSum);
            cnt += PathSum(root.left, targetSum);
            cnt += PathSum(root.right, targetSum);
            return cnt;
        }
    }

    public static void Test() {
        var root = new TreeNode("[10,5,-3,3,2,null,11,3,-2,null,1]");
        var s = new Solution();
        var ans = s.PathSum(root, 8);
        Console.WriteLine(ans);
    }
}