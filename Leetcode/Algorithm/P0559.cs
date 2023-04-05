/*
 * Author: Deean
 * Date: 2023-04-05 16:51:18
 * FileName: P0559.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm;

public class P0559 {
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
        public int MaxDepth(Node root) {
            if (root == null) return 0;
            int maximum = 0;
            foreach (var node in root.children) {
                int childDepth = MaxDepth(node);
                maximum = Math.Max(maximum, childDepth);
            }
            return maximum + 1;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.MaxDepth(null);
        Console.WriteLine(ans);
    }
}