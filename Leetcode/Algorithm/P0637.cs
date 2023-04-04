/*
 * Author: Deean
 * Date: 2023-04-04 12:47:04
 * FileName: P0637.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P0637 {
    public class Solution {
        public IList<double> AverageOfLevels(TreeNode root) {
            IList<double> average = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                double sum = 0;
                int size = queue.Count;
                for (int i = 0; i < size; i++) {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                    }
                }
                average.Add(sum / size);
            }
            return average;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.AverageOfLevels(new TreeNode("[3,9,20,null,null,15,7]"));
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}