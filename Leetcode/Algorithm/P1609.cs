/*
 * Author: Deean
 * Date: 2023-06-05 22:44:49
 * FileName: P1609.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P1609 {
    public class Solution {
        public bool IsEvenOddTree(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 0;
            queue.Enqueue(root);
            while (queue.Count != 0) {
                IList<int> values = new List<int>();
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (level % 2 == 0) {
                        if (node.val % 2 == 0) return false;
                        values.Add(node.val);
                    } else {
                        if (node.val % 2 == 1) return false;
                        values.Insert(0, node.val);
                    }
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                for (int i = 0, n = values.Count; i < n - 1; i++) {
                    // Console.WriteLine(Arrays.ToString(values.ToArray()));
                    if (values[i] >= values[i + 1]) {
                        return false;
                    }
                }
                level += 1;
            }
            return true;
        }
    }

    public static void Test() {
        var root = new TreeNode("[5,9,1,3,5,7]");
        var s = new Solution();
        var ans = s.IsEvenOddTree(root);
        Console.WriteLine(ans);
    }
}