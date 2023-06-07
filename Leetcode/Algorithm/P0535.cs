/*
 * Author: Deean
 * Date: 2023-06-06 23:16:13
 * FileName: P0535.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm;

public class P0535 {
    public class Codec {
        private IDictionary<int, string> dict = new Dictionary<int, string>();

        private int code = 1;

        // Encodes a URL to a shortened URL
        public string encode(string longUrl) {
            dict[code++] = longUrl;
            return "http://tinyurl.com/" + (code - 1);
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl) {
            string ss = shortUrl.Split('/').Last();
            return dict[int.Parse(ss)];
        }
    }

    public static void Test() {
        string url = "https://leetcode.com/problems/design-tinyurl";
        Codec codec = new Codec();
        Console.WriteLine(codec.decode(codec.encode(url)));
    }
}