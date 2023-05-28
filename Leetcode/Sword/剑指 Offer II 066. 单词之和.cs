/*
 * Author: Deean
 * Date: 2023-05-27 22:45:26
 * FileName: 剑指 Offer II 066. 单词之和.cs
 * Description:
*/

using System;
using System.Collections.Generic;

namespace Sword;

public class 剑指_Offer_II_066__单词之和 {
    public class MapSum {
        private IDictionary<string, int> dict;

        public MapSum() {
            dict = new Dictionary<string, int>();
        }

        public void Insert(string key, int val) {
            dict[key] = val;
        }

        public int Sum(string prefix) {
            int cnt = 0;
            foreach (var k in dict.Keys) {
                if (k.StartsWith(prefix)) {
                    cnt += dict[k];
                }
            }
            return cnt;
        }
    }

    public static void Test() {
        MapSum obj = new MapSum();
        obj.Insert("apple", 3);
        Console.WriteLine(obj.Sum("ap"));
        obj.Insert("app", 2);
        Console.WriteLine(obj.Sum("ap"));
    }
}