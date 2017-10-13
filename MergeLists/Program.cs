using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
  //Definition for singly-linked list.    
  public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
        public override string ToString()
        {
            ListNode t = this;
            StringBuilder sb = new StringBuilder();
            while (t!=null)
            {
                sb.Append(t.val);
                t = t.next;
            }
            return sb.ToString();
        }
    }

    public class Program
    {
        public static void Main(string []args)
        {
            ListNode l11 = new ListNode(1);
            ListNode l12 = new ListNode(3);
            l11.next = l12;
            ListNode l13 = new ListNode(5);
            l12.next = l13;

            ListNode l21 = new ListNode(2);
            ListNode l22 = new ListNode(4);
            l21.next = l22;
            ListNode l23 = new ListNode(6);
            l23.next = l23;

            Console.WriteLine(MergeTwoLists(l11,l21).ToString());
            Console.ReadKey();
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode a = new ListNode(Math.Min(l1.val, l2.val));

            ListNode p1 = l1.next;
            ListNode p2 = l2.next;
            ListNode l = a;

            bool isl1over, isl2over;

            while (p1 != null || p2 != null)
            {
                isl1over = (p1 == null);
                isl2over = (p2 == null);

                if (!isl1over && !isl2over)
                {
                    if (p1.val < p2.val)
                    {
                        a.next = new ListNode(p1.val);
                        p1 = p1.next;
                    }
                    else if (p1.val > p2.val)
                    {
                        a.next = new ListNode(p2.val);
                        p2 = p2.next;
                    }
                    else
                    {
                        a.next = new ListNode(p2.val);
                        p1 = p1.next;
                        p2 = p2.next;
                    }
                }

                if (isl1over && !isl2over)
                {
                    l = new ListNode(p2.val);
                    p2 = p2.next;
                }

                if (isl2over && !isl1over)
                {
                    l = new ListNode(p1.val);
                    p1 = p1.next;
                }
                //l = l.next;
            }
            return a;
        }
    }
}
