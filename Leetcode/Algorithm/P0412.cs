/*
 * Author: Deean
 * Date: 2023-04-05 20:06:51
 * FileName: P0412.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm; 

public class P0412 {
    public class Solution {
        public IList<string> FizzBuzz(int n) {
            IList<string> list = new List<string>();
            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    list.Add("FizzBuzz");
                } else if (i % 3 == 0) {
                    list.Add("Fizz");
                } else if (i % 5 == 0) {
                    list.Add("Buzz");
                } else {
                    list.Add(i.ToString());
                }
            }
            return list;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.FizzBuzz(15);
        Console.WriteLine(lib.Arrays.ToString(ans.ToArray()));
    }
}