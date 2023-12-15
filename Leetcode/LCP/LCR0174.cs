/*
 * Author: Deean
 * Date: 2023-12-13 22:01:02
 * FileName: LCR0174.cs
 * Description: LCR 174. 寻找二叉搜索树中的目标节点
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0174 {
    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(TreeNode root) {
            if (root == null) return;
            DFS(root.right);
            values.Add(root.val);
            DFS(root.left);
        }

        public int FindTargetNode(TreeNode root, int cnt) {
            DFS(root);
            return values[cnt - 1];
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindTargetNode(new TreeNode("[7,3,9,1,5]"), 2);
        Console.WriteLine(ans);
    }
}