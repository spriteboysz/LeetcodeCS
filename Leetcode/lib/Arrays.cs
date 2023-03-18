/*
 * Author: Deean
 * Date: 2023-03-18 16:41:43
 * FileName: Array.cs
 * Description:
*/

using System;
using System.Text;

namespace lib {
    public class Arrays {
        public static String ToString(int [] nums) {
            StringBuilder ss = new StringBuilder();
            foreach (var num in nums) {
                ss.Append(num);
                ss.Append(",");
            }
            ss.Remove(ss.Length - 1, 1);
            return "[" + ss + "]";
        }
    }
}