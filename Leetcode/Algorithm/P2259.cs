/*
 * Author: Deean
 * Date: 2023-03-19 12:45:15
 * FileName: P2259.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Algorithm; 

public class P2259 {
    public class Solution {
        public string RemoveDigit(string number, char digit) {
            List<string> list = new List<string>();
            for (int i = 0; i < number.Length; i++) {
                if (number[i] == digit) {
                    list.Add(number.Substring(0,i) + number.Substring(i+1));
                }
            }
            string maximum = "0";
            foreach (var item in list) {
                // ReSharper disable once StringCompareIsCultureSpecific.1
                if (String.Compare(item, maximum) == 1) {
                    maximum = item;
                }
            }
            return maximum;
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.RemoveDigit("123", '3');
        Console.WriteLine(ans);
    }
}