/*
 * Author: Deean
 * Date: 2023-05-20 15:08:08
 * FileName: P2652.cs
 * Description:
*/

namespace Algorithm;

public class P2652 {
    public class Solution {
        public int SumOfMultiples(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0) {
                    sum += i;
                }
            }
            return sum;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.SumOfMultiples(7);
        System.Console.WriteLine(ans);
    }
}