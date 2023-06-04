/*
 * Author: Deean
 * Date: 2023-06-03 21:32:22
 * FileName: P0095.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0095 {
    public class Solution {
        private IList<TreeNode> CreateTree(int left, int right) {
            IList<TreeNode> trees = new List<TreeNode>();
            if (left > right) {
                trees.Add(null);
                return trees;
            }
            for (int i = left; i <= right; i++) {
                var leftTree = CreateTree(left, i - 1);
                var rightTree = CreateTree(i + 1, right);
                foreach (var leftNode in leftTree) {
                    foreach (var rightNode in rightTree) {
                        var root = new TreeNode(i) {
                            left = leftNode,
                            right = rightNode
                        };
                        trees.Add(root);
                    }
                }
            }
            return trees;
        }

        public IList<TreeNode> GenerateTrees(int n) {
            if (n == 0) return new List<TreeNode>();
            return CreateTree(1, n);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GenerateTrees(3);
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}