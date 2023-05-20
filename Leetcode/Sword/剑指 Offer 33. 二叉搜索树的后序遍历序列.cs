/*
 * Author: Deean
 * Date: 2023-05-20 20:14:13
 * FileName: 剑指 Offer 33. 二叉搜索树的后序遍历序列.cs
 * Description:
*/

using System;

namespace Sword;

public class 剑指_Offer_33__二叉搜索树的后序遍历序列 {
    public class Solution {
        public bool Check(int[] postorder, int left, int root) {
            if (left >= root) return true;
            int index = left;
            while (postorder[index] < postorder[root]) index++;
            int right = index;
            while (postorder[index] > postorder[root]) index++;
            return index == root && Check(postorder, left, right - 1) && Check(postorder, right, root - 1);
        }

        public bool VerifyPostorder(int[] postorder) {
            return Check(postorder, 0, postorder.Length - 1);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.VerifyPostorder(new[] { 1, 3, 2, 6, 5 });
        Console.WriteLine(ans);
    }
}