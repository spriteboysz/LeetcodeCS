/*
 * Author: Deean
 * Date: 2023-04-09 10:22:59
 * FileName: 面试题 10.01. 合并排序的数组.cs
 * Description:
*/

using System;

namespace Interview; 

public class 面试题_10_01__合并排序的数组 {
    public class Solution {
        public void Merge(int[] A, int m, int[] B, int n) {
            for (int i = m; i < n + m; i++) {
                A[i] = B[i - m];
            }
            Array.Sort(A);
            Console.WriteLine(lib.Arrays.ToString(A));
        } 
    }

    public static void Test() {
        var s = new Solution();
        s.Merge(new[]{1,2,3,0,0,0}, 3,new[]{2,5,6}, 3);
    }
}