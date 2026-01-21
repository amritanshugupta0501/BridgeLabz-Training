using System.Collections.Generic;
public class NthElementFinder
{
    public class ListNode
    {
        public string Value;
        public ListNode Next;
        public ListNode(string val) { Value = val; Next = null; }
    }
    public static string FindNthFromEnd(ListNode head, int n)
    {
        ListNode mainPtr = head;
        ListNode refPtr = head;
        int count = 0;
        if (head == null) return null;
        while (count &lt; n)
        {
            if (refPtr == null) return null;
            refPtr = refPtr.Next;
            count++;
        }
        while (refPtr != null)
        {
            mainPtr = mainPtr.Next;
            refPtr = refPtr.Next;
        }
        return mainPtr.Value;
    }
    public static void Main(string[] args)
    {
        ListNode head = new ListNode("A");
        head.Next = new ListNode("B");
        head.Next.Next = new ListNode("C");
        head.Next.Next.Next = new ListNode("D");
        head.Next.Next.Next.Next = new ListNode("E");
        Console.WriteLine("Linked list: A -> B -> C -> D -> E");
        string result = FindNthFromEnd(head, 2);
        Console.WriteLine($"2nd from end: {result}");
        result = FindNthFromEnd(head, 1);
        Console.WriteLine($"1st from end: {result}");
    }
}