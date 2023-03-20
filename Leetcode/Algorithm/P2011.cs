/*
 * Author: Deean
 * Date: 2023-03-19 19:43:01
 * FileName: P2011.cs
 * Description:
*/

using System;

namespace Algorithm; 

public class P2011 {
    public class Solution {
        public int FinalValueAfterOperations(string[] operations) {
            int x = 0;
            foreach (var operation in operations) {
                if (operation[1] == '+') {
                    x++;
                } else {
                    x--;
                }
            }
            return x;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FinalValueAfterOperations(new []{"--X","X++","X++"});
        Console.WriteLine(ans);
    }
}