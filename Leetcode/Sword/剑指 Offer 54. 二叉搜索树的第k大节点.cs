/*
 * Author: Deean
 * Date: 2023-04-08 16:25:56
 * FileName: 剑指 Offer 54. 二叉搜索树的第k大节点.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Sword;

public class 剑指_Offer_54__二叉搜索树的第k大节点 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.right);
            values.Add(root.val);
            DFS(root.left);
        }

        public int KthLargest(TreeNode root, int k) {
            DFS(root);
            return values[k - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.KthLargest(new TreeNode("[5,3,6,2,4,null,null,1]"), 3);
        Console.WriteLine(ans);
    }
}