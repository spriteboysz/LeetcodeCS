/*
 * Author: Deean
 * Date: 2023-04-05 17:23:25
 * FileName: P0589.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0589 {
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {
        }

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }

    public class Solution {
        private IList<int> values = new List<int>();

        private void DFS(Node root) {
            if (root == null) return;
            values.Add(root.val);
            foreach (var child in root.children) {
                DFS(child);
            }
        }

        public IList<int> Preorder(Node root) {
            DFS(root);
            return values;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Preorder(new Node(1));
        Console.WriteLine(ans.ToArray());
    }
}