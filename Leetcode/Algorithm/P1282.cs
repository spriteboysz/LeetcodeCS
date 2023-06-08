/*
 * Author: Deean
 * Date: 2023-06-07 22:10:42
 * FileName: P1282.cs
 * Description:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace Algorithm;

public class P1282 {
    public class Solution {
        public IList<IList<int>> GroupThePeople(int[] groupSizes) {
            IDictionary<int, IList<int>> groups = new Dictionary<int, IList<int>>();
            for (int i = 0, n = groupSizes.Length; i < n; i++) {
                int size = groupSizes[i];
                if (!groups.ContainsKey(size)) {
                    groups[size] = new List<int>();
                }
                groups[size].Add(i);
            }
            IList<IList<int>> groupList = new List<IList<int>>();
            foreach (var kv in groups) {
                int size = kv.Key;
                IList<int> people = kv.Value;
                for (int i = 0; i < people.Count / size; i++) {
                    IList<int> group = new List<int>();
                    int start = i * size;
                    for (int j = 0; j < size; j++) {
                        group.Add(people[start + j]);
                    }
                    groupList.Add(group);
                }
            }
            return groupList;
        }
    }

    public static void Test() {
        var s = new Solution();
        var ans = s.GroupThePeople(new[] { 3, 3, 3, 3, 3, 1, 3 });
        Console.WriteLine(Arrays.ToString(ans.ToArray()));
    }
}