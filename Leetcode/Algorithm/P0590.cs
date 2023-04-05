/*
 * Author: Deean
 * Date: 2023-04-05 17:28:24
 * FileName: P0590.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0590 {
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

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

        private void DFS(Node node) {
            if (node == null) return;
            foreach (var child in node.children) {
                DFS(child);
            }
            values.Add(node.val);
        }
        public IList<int> Postorder(Node root) {
            DFS(root);
            return values;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.Postorder(new Node(1));
        Console.WriteLine(ans.ToArray());
    }
}