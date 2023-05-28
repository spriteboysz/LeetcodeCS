/*
 * Author: Deean
 * Date: 2023-05-27 22:29:31
 * FileName: P0676.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0676 {
    public class MagicDictionary {
        private IList<string> dict;

        public MagicDictionary() {
            dict = new List<string>();
        }

        public void BuildDict(string[] dictionary) {
            dict = dictionary.ToList();
        }

        public bool Search(string searchWord) {
            foreach (var word in dict) {
                if (searchWord.Length != word.Length) continue;
                int cnt = 0;
                for (int i = 0, n = word.Length; i < n; i++) {
                    if (word[i] != searchWord[i]) {
                        cnt++;
                        if (cnt > 1) break;
                    }
                }
                if (cnt == 1) return true;
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