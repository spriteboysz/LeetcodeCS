/*
 * Author: Deean
 * Date: 2023-06-04 23:33:34
 * FileName: P1161.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P1161 {
    public class Solution {
        public int MaxLevelSum(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 1, maxLevel = 1, maximum = Int32.MinValue;
            while (queue.Count != 0) {
                int sum = 0;
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (sum > maximum) {
                    maximum = sum;
                    maxLevel = level;
                }
                level += 1;
            }
            return maxLevel;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,7,0,7,-8,null,null]");
        var s = new Solution();
        var ans = s.MaxLevelSum(root);
        Console.WriteLine(ans);
    }
}