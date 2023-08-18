/*
 * Author: Deean
 * Date: 2023-08-16 23:27:43
 * FileName: P2748.cs
 * Description:2748. 美丽下标对的数目
 */

using System;

namespace Algorithm;

public class P2748 {
    public class Solution {
        public int Gcd(int a, int b) {
            while (b != 0) {
                int i = b;
                b = a % b;
                a = i;
            }
            return a;
        }

        public int CountBeautifulPairs(int[] nums) {
            int cnt = 0;
            for (int i = 0, n = nums.Length; i < n; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (Gcd((int)Char.GetNumericValue(nums[i].ToString()[0]), nums[j] % 10) == 1) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.CountBeautifulPairs(new[] { 11, 21, 12 });
        Console.WriteLine(ans);
    }
}