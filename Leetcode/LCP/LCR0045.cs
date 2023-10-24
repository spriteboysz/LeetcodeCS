/*
 * Author: Deean
 * Date: 2023-10-23 21:33:31
 * FileName: LCR0045.cs
 * Description: LCR 045. 找树左下角的值
 */

using System;
using System.Collections.Generic;
using lib;

namespace LCP;

public class LCR0045 {
    public class Solution {
        public int FindBottomLeftValue(TreeNode root) {
            int target = root.val;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                for (int i = 0, n = queue.Count; i < n; i++) {
                    var node = queue.Dequeue();
                    if (i == 0) {
                        target = node.val;
                    }
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            return target;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FindBottomLeftValue(new TreeNode("[1,2,3,4,null,5,6,null,null,7]"));
        Console.WriteLine(ans);
    }
}