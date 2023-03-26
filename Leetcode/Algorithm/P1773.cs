/*
 * Author: Deean
 * Date: 2023-03-25 22:52:23
 * FileName: P1773.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P1773 {
    public class Solution {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
            string[] rule =  { "type", "color", "name" };
            int index = Array.IndexOf(rule, ruleKey);
            return items.Count(item => item[index] == ruleValue);
        }
    }

    public static void Test() {
        IList<IList<String>> items = new List<IList<string>>();
        IList<String> item0 = new List<String> { "phone", "blue", "pixel" };
        IList<String> item1 = new List<String> { "computer", "silver", "lenovo" };
        IList<String> item2 = new List<String> { "phone", "blue", "pixel" };
        items.Add(item0);
        items.Add(item1);
        items.Add(item2);
        var s = new Solution();
        var ans = s.CountMatches(items, "color", "silver");
        Console.WriteLine(ans);
    }
}