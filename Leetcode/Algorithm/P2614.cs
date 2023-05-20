/*
 * Author: Deean
 * Date: 2023-05-19 22:56:47
 * FileName: P2614.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P2614 {
    public class Solution {
        public bool IsPrime(int num) {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public int DiagonalPrime(int[][] nums) {
            var diagonal = new HashSet<int>();
            for (int i = 0, n = nums.Length; i < n; i++) {
                if (IsPrime(nums[i][i])) diagonal.Add(nums[i][i]);
                if (IsPrime(nums[i][n - 1 - i])) diagonal.Add(nums[i][n - 1 - i]);
            }
            return diagonal.Count == 0 ? 0 : diagonal.ToList().Max();
        }
    }

    public static void Test() {
        var s = new Solution();
        var nums = Arrays.To2DArray("[[1,2,3],[5,17,7],[9,11,10]]");
        var ans = s.DiagonalPrime(nums);
        Console.WriteLine(ans);
    }
}