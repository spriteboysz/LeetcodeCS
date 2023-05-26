/*
 * Author: Deean
 * Date: 2023-05-26 22:26:14
 * FileName: P0173.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using lib;

namespace Algorithm;

public class P0173 {
    public class BSTIterator {
        private Queue<int> queue;

        private void dfs(TreeNode root) {
            if (root == null) return;
            dfs(root.left);
            queue.Enqueue(root.val);
            dfs(root.right);
        }

        public BSTIterator(TreeNode root) {
            queue = new Queue<int>();
            dfs(root);
        }

        public int Next() {
            return queue.Dequeue();
        }

        public bool HasNext() {
            return queue.Count > 0;
        }
    }

    public static void Test() {
        var root = new TreeNode("[7,3,15,null,null,9,20]");
        var obj = new BSTIterator(root);
        Console.WriteLine(obj.Next());
        Console.WriteLine(obj.HasNext());
    }
}