using System;
using System.Collections.Generic;
using DataStructures;
using DataStructuresAndALghorithms.DataStructures;
using DataStructuresTest;

public class ListNode{
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
             }
}
class Program
{
    
    static void Main()
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(4);
        head.next.next = new ListNode(5);
        ListNode head2 = new ListNode(1);
        head2.next = new ListNode(3);
        head2.next.next = new ListNode(4);
        ListNode head3 = new ListNode(2);
        head3.next = new ListNode(6);
        ListNode[] lists = new ListNode[] { head, head2, head3 };
        ListNode result = MergeKLists(lists);
        ListNode temp = result;
        while (temp != null) {
        Console.Write($" {temp.val} ");
        }
    }
    static ListNode MergeKLists(ListNode[] lists)
    {
        ListNode result = new ListNode();
        ListNode tail = result;
        PriorityQueue<ListNode,int> queue = new PriorityQueue<ListNode,int>();
        while(true)
        {
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    queue.Enqueue(lists[i], lists[i].val);
                    lists[i] = lists[i].next;
                }
            }
            if (queue.Count <= 0) break;
            tail.val =queue.Dequeue().val; 
            tail.next = new ListNode();
        }
        tail.next = null;
        result = result.next;
        return result;
    }

}