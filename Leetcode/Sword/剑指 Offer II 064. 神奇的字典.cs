/*
 * Author: Deean
 * Date: 2023-05-27 21:45:21
 * FileName: 剑指 Offer II 064. 神奇的字典.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sword;

public class 剑指_Offer_II_064__神奇的字典 {
    public class MagicDictionary {
        private IList<string> dict;

        public MagicDictionary() {
            dict = new List<string>();
        }

        public void BuildDict(string[] dictionary) {
            dict = dictionary.ToList();
        }

        public bool Search(string searchWord) {
            foreach (string word in dict) {
                if (word.Length != searchWord.Length) continue;
                int diff = 0;
                for (int i = 0; i < word.Length; ++i) {
                    if (word[i] != searchWord[i]) {
                        ++diff;
                        if (diff > 1) break;
                    }
                }
                if (diff == 1) return true;
            }
            return false;
        }
    }

    public static void Test() {
        MagicDictionary obj = new MagicDictionary();
        obj.BuildDict(new[] { "hello", "leetcode" });
        Console.WriteLine(obj.Search("hello"));
        Console.WriteLine(obj.Search("heelo"));
        Console.WriteLine(obj.Search("leetcooe"));
    }
}