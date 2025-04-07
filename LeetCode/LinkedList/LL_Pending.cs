using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LL_Pending
    {
        //using System;
        //using System.Collections;
        //using System.Collections.Generic;
        //using System.Diagnostics.Metrics;
        //using System.Linq;
        //using System.Text;
        //using System.Threading.Tasks;
        //using System.Xml.Linq;
        //using static System.Net.Mime.MediaTypeNames;




        //int[] values = { 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9 };
        //int[] values1 = { 5, 6, 4, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9, 9, 9, 9 };
        //ListNode head = CreateLinkedList(values);
        //ListNode head1 = CreateLinkedList(values1);
        //var a = AddTwoNumbers(head, head1);
        ////Console.WriteLine(HasCycle(head));
        //PrintLinkedList(a);

        //ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    ListNode current = l1;
        //    string f = "", s = "";
        //    List<ListNode> List_LL = new();
        //    while (current != null)
        //    {
        //        List_LL.Add(current);
        //        f = current.val + f;
        //        current = current.next;
        //    }

        //    ListNode current1 = l2;
        //    List<ListNode> List_LL1 = new();
        //    while (current1 != null)
        //    {
        //        List_LL1.Add(current1);
        //        s = current1.val + s;

        //        current1 = current1.next;
        //    }
        //    string ans = (Int128.Parse(f) + Int128.Parse(s)).ToString();

        //    var c = ans.ToCharArray();
        //    c=c.Reverse().ToArray();
        //    ListNode ret = null;
        //    for (int i = 0; i < c.Length; i++)
        //    {
        //        var node = new ListNode();
        //        node.val = Int32.Parse(c[i].ToString());
        //        if (ret == null)
        //        {
        //            ret = node;
        //        }
        //        else
        //        {
        //            var d = ret;
        //            while (d.next != null)
        //                d = d.next;
        //            d.next = node;

        //        }
        //    }
        //    return ret;
        //}


        //ListNode MergeTwoLists(ListNode list1, ListNode list2)
        //{
        //    ListNode current = list1;
        //    List<ListNode> List_LL = new();
        //    while (current != null)
        //    {
        //        List_LL.Add(current);
        //        current = current.next;
        //    }

        //    ListNode current1 = list2;
        //    List<ListNode> List_LL1 = new();
        //    while (current1 != null)
        //    {
        //        List_LL1.Add(current1);
        //        current1 = current1.next;
        //    }
        //    ListNode ret = null;
        //    int l1counter = 0, l2counter = 0;
        //    for (int i = 0; i < List_LL.Count() + List_LL1.Count(); i++)
        //    {
        //        var node = new ListNode();
        //        if (l2counter < List_LL1.Count() && l1counter < List_LL.Count())
        //        {
        //            if (List_LL[l1counter].val < List_LL1[l2counter].val)
        //            {
        //                node.val = List_LL[l1counter].val;
        //                l1counter++;
        //            }
        //            else
        //            {
        //                node.val = List_LL1[l2counter].val;
        //                l2counter++;
        //            }
        //            if (ret == null)
        //            {
        //                ret = node;
        //            }
        //            else
        //            {
        //                var d = ret;
        //                while (d.next != null)
        //                    d = d.next;
        //                d.next = node;
        //            }
        //        }
        //        else if (l2counter < List_LL1.Count())
        //        {
        //            node.val = List_LL1[l2counter].val;
        //            l2counter++;
        //            if (ret == null)
        //            {
        //                ret = node;
        //            }
        //            else
        //            {
        //                var d = ret;
        //                while (d.next != null)
        //                    d = d.next;
        //                d.next = node;
        //            }
        //        }
        //        else if (l1counter < List_LL.Count())
        //        {
        //            node.val = List_LL[l1counter].val;
        //            l1counter++;
        //            if (ret == null)
        //            {
        //                ret = node;
        //            }
        //            else
        //            {
        //                var d = ret;
        //                while (d.next != null)
        //                    d = d.next;
        //                d.next = node;
        //            }
        //        }
        //    }

        //    return ret;
        //}
        //bool HasCycle(ListNode head)
        //{
        //    ListNode current = head;
        //    List<ListNode> List_LL = new();
        //    while (current != null)
        //    {
        //        List_LL.Add(current);
        //        current = current.next;
        //    }
        //    return true;
        //}
        //int PairSum(ListNode head)
        //{
        //    ListNode current = head;
        //    List<ListNode> List_LL = new();
        //    int counter = 1;
        //    while (current != null)
        //    {
        //        List_LL.Add(current);
        //        current = current.next;
        //        counter++;
        //    }
        //    int maxSum = 0;
        //    int n = List_LL.Count();
        //    for (int i = 0; i < n; i++)
        //    {
        //        int nectIndex = (n - 1 - i);
        //        int sum = List_LL[i].val + List_LL[nectIndex].val;
        //        maxSum = Math.Max(maxSum, sum);
        //    }
        //    return maxSum;

        //}
        //ListNode OddEvenList(ListNode head)
        //{
        //    ListNode current = head;
        //    ListNode Odd = null;
        //    ListNode Even = null;
        //    int counter = 1;
        //    while (current != null)
        //    {
        //        ListNode next = new();
        //        next.val = current.val;
        //        if (counter % 2 == 0)
        //        {
        //            var d = Even;
        //            if (d == null)
        //            {
        //                Even = next;
        //            }
        //            else
        //            {
        //                while (d.next != null)
        //                    d = d.next;
        //                d.next = next;
        //            }
        //        }
        //        else
        //        {
        //            if (Odd == null)
        //            {
        //                Odd = next;
        //            }
        //            else
        //            {
        //                var d = Odd;
        //                while (d.next != null)
        //                    d = d.next;

        //                d.next = next;

        //            }
        //        }
        //        counter++;
        //        current = current.next;

        //    }

        //    var dd = Odd;
        //    while (dd.next != null)
        //        dd = dd.next;
        //    dd.next = Even;
        //    return Odd;

        //}
        //static void PrintLinkedList(ListNode a)
        //{
        //    ListNode current = a;
        //    while (current != null)
        //    {
        //        Console.Write(current.val + " ");
        //        current = current.next;
        //    }
        //    Console.WriteLine();
        //}

        //static ListNode CreateLinkedList(int[] values)
        //{
        //    if (values.Length == 0) return null;

        //    ListNode head = new ListNode(values[0]);
        //    ListNode current = head;

        //    for (int i = 1; i < values.Length; i++)
        //    {
        //        current.next = new ListNode(values[i]);
        //        current = current.next;
        //    }

        //    return head;
        //}

        //ListNode DeleteMiddle(ListNode head)
        //{
        //    var current = head;
        //    var count = 0;
        //    while (current != null)
        //    {
        //        count++;
        //        current = current.next;
        //    }
        //    current = head;
        //    if (count == 1)
        //    {
        //        return current.next;
        //    }
        //    var elementnnedToRemoveAt = 0;
        //    if (count % 2 == 0)
        //    {
        //        count++;
        //    }
        //    elementnnedToRemoveAt = (count + 1) / 2;

        //    for (int i = 0; i < elementnnedToRemoveAt - 2; i++)
        //    {
        //        current = current.next;
        //    }
        //    current.next = current.next.next;

        //    return head;
        //}
        //ListNode Reverse_List(ListNode head)
        //{

        //    List<int> a = new List<int>();
        //    ListNode headpoint = new();
        //    if (head != null)
        //    {
        //        ListNode current = head;
        //        while (current.next != null)
        //        {
        //            a.Add(current.val);
        //            current = current.next;
        //        }
        //        a.Add(current.val);
        //    }
        //    a.Reverse();// (s => s);
        //    headpoint = null;
        //    foreach (var val in a)
        //    {
        //        ListNode node = new();
        //        node.val = val;
        //        if (headpoint == null)
        //        {
        //            headpoint = node;
        //        }
        //        else
        //        {
        //            var current = headpoint;
        //            while (current.next != null)
        //                current = current.next;
        //            current.next = node;
        //        }
        //    }
        //    return headpoint;
        //}

        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}

    }
}
