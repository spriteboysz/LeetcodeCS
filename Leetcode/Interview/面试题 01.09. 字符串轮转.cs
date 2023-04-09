/*
 * Author: Deean
 * Date: 2023-04-08 20:50:05
 * FileName: 面试题 01.09. 字符串轮转.cs
 * Description:
*/

using System;

namespace Interview; 

public class 面试题_01_09__字符串轮转 {
    public class Solution {
        public bool IsFlipedString(string s1, string s2) {
            if (s1.Length != s2.Length) return false;
            return (s1 + s1).Contains(s2);
        } 
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.IsFlipedString("waterbottle", "erbottlewat");
        Console.WriteLine(ans);
    }
}