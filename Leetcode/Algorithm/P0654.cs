/*
 * Author: Deean
 * Date: 2023-06-05 23:25:10
 * FileName: P0654.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0654 {
    public class Solution {
        private TreeNode create(int[] nums, int left, int right) {
            if (left >= right) return null;
            int maximum = nums[left], index = left;
            for (int i = left; i < right; i++) {
                if (maximum < nums[i]) {
                    maximum = nums[i];
                    index = i;
                }
            }
            var root = new TreeNode(maximum) {
                left = create(nums, left, index),
                right = create(nums, index + 1, right)
            };
            return root;
        }

        public TreeNode ConstructMaximumBinaryTree(int[] nums) {
            return create(nums, 0, nums.Length);
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.ConstructMaximumBinaryTree(new[] { 3, 2, 1, 6, 0, 5 });
        Console.WriteLine(ans);
    }
}