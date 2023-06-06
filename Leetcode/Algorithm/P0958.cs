/*
 * Author: Deean
 * Date: 2023-06-05 23:00:53
 * FileName: P0958.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0958 {
    public class Solution {
        public bool IsCompleteTree(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            bool flag = false;
            queue.Enqueue(root);
            while (queue.Count != 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (node.left != null) {
                        if (flag) return false;
                        queue.Enqueue(node.left);
                    } else {
                        flag = true;
                    }
                    if (node.right != null) {
                        if (flag) return false;
                        queue.Enqueue(node.right);
                    } else {
                        flag = true;
                    }
                }
            }
            return true;
        }
    }

    public static void Test() {
        var root = new TreeNode("[1,2,3,4,5,6]");
        var s = new Solution();
        var ans = s.IsCompleteTree(root);
        Console.WriteLine(ans);
    }
}