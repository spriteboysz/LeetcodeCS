/*
 * Author: Deean
 * Date: 2023-06-03 21:11:18
 * FileName: P0707.cs
 * Description:
*/

using System;
using lib;

namespace Algorithm;

public class P0707 {
    public class MyLinkedList {
        private int size;
        private ListNode head;

        public MyLinkedList() {
            size = 0;
            head = new ListNode();
        }

        public int Get(int index) {
            if (index < 0 || index >= size) {
                return -1;
            }
            var cur = head;
            for (int i = 0; i <= index; i++) {
                cur = cur.next;
            }
            return cur.val;
        }

        public void AddAtHead(int val) {
            AddAtIndex(0, val);
        }

        public void AddAtTail(int val) {
            AddAtIndex(size, val);
        }

        public void AddAtIndex(int index, int val) {
            if (index > size) return;
            index = Math.Max(0, index);
            size++;
            var pre = head;
            for (int i = 0; i < index; i++) {
                pre = pre.next;
            }
            var target = new ListNode(val) {
                next = pre.next
            };
            pre.next = target;
        }

        public void DeleteAtIndex(int index) {
            if (index < 0 || index >= size) return;
            size--;
            var pre = head;
            for (int i = 0; i < index; i++) {
                pre = pre.next;
            }
            pre.next = pre.next.next;
        }
    }

    public static void Test() {
        MyLinkedList obj = new MyLinkedList();
        Console.WriteLine(obj.Get(1));
        obj.AddAtHead(1);
        obj.AddAtTail(3);
        obj.AddAtIndex(1, 2);
        Console.WriteLine(obj.Get(1));
        obj.DeleteAtIndex(1);
        Console.WriteLine(obj.Get(1));
    }
}