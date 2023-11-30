/*
 * Author: Deean
 * Date: 2023-11-30 22:54:26
 * FileName: LCR0152.cs
 * Description: LCR 152. 验证二叉搜索树的后序遍历序列
 */

using System;

namespace LCP;

public class LCR0152 {
    public class Solution {
        public bool VerifyTreeOrder(int[] postorder) {
            return Check(postorder, 0, postorder.Length - 1);
        }

        public bool Check(int[] postorder, int left, int root) {
            if (left >= root) return true;
            int index = left;
            while (postorder[index] < postorder[root]) index++;
            int right = index;
            while (postorder[index] > postorder[root]) index++;
            return index == root && Check(postorder, left, right - 1) && Check(postorder, right, root - 1);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.VerifyTreeOrder(new[] { 4, 9, 6, 9, 8 });
        Console.WriteLine(ans);
    }
}