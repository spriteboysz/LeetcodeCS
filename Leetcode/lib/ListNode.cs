/*
 * Author: Deean
 * Date: 2023-03-31 22:05:33
 * FileName: ListNode.cs
 * Description:
*/

using System.Linq;
using System.Text;

namespace lib;

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }

    public ListNode(string s) {
        int[] values = s.Substring(1, s.Length - 2).Split(',').Select(int.Parse).ToArray();
        int n = values.Length;
        if (n == 0) {
            val = -1;
            return;
        }
        ListNode[] nodes = new ListNode[n];
        nodes[0] = new ListNode(values[0]);
        for (int i = 1; i < n; i++) {
            nodes[i] = new ListNode(values[i]);
            nodes[i - 1].next = nodes[i];
        }
        nodes[n - 1].next = null;
        val = nodes[0].val;
        next = nodes[0].next;
    }

    public override string ToString() {
        StringBuilder ss = new StringBuilder();
        ss.Append("[");
        ListNode head = this;
        while (head != null) {
            ss.Append(head.val);
            ss.Append(",");
            head = head.next;
        }
        ss.Remove(ss.Length - 1, 1);
        ss.Append("]");
        return ss.ToString();
    }
}