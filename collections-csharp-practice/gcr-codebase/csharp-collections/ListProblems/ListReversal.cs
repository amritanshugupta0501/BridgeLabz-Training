using System;
using System.Collections.Generic;
public class ListReversal
{
    public static void ReverseList&lt;T&gt;(List&lt;T&gt; list)
    {
        int start = 0;
        int end = list.Count - 1;
        while (start &lt; end)
        {
            T temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }
    }
    public class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int val) { Value = val; Next = null; }
    }
    public static ListNode ReverseLinkedList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
    public static void Main(string[] args)
    {
        List&lt;int&gt; list = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original list:");
        foreach (var i in list) Console.Write(i + " ");
        Console.WriteLine();
        ReverseList(list);
        Console.WriteLine("Reversed list:");
        foreach (var i in list) Console.Write(i + " ");
        Console.WriteLine();
        ListNode head = new ListNode(1);
        head.Next = new ListNode(2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(4);
        Console.WriteLine("Original linked list:");
        ListNode temp = head;
        while (temp != null) { Console.Write(temp.Value + " "); temp = temp.Next; }
        Console.WriteLine();
        ListNode rev = ReverseLinkedList(head);
        Console.WriteLine("Reversed linked list:");
        while (rev != null) { Console.Write(rev.Value + " "); rev = rev.Next; }
        Console.WriteLine();
    }
}