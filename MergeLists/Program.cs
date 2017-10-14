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
                sb.Append("->");
                t = t.next;
            }
            
            return sb.ToString().TrimEnd(new char[] { '-','>'});
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
            l22.next = l23;
            Console.WriteLine("Input List 1:" + l11.ToString());
            Console.WriteLine("Input List 2:" + l21.ToString());
            ListNode res = MergeTwoLists(l11, l21);
            Console.WriteLine("Merged List:" + (res == null ? string.Empty : res.ToString())+"\n--END--");
            Console.ReadKey();
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2, bool isUniqueConstraint = false)
        {
            ListNode a = null, p1 = l1, p2 = l2, ans = a;
            while (true)
            {
                if (p1 == null && p2 == null)
                    return ans;

                else if (p1 != null && p2 == null)
                {
                    a = new ListNode(p1.val)
                    {
                        next = null
                    };
                    p1 = p1.next;
                    a = a.next;
                }

                else if (p1 == null && p2 != null)
                {
                    a = new ListNode(p2.val)
                    {
                        next = null
                    };
                    p2 = p2.next;
                    a = a.next;
                }

                else
                {
                    if (p1.val < p2.val)
                    {
                        a = new ListNode(p1.val)
                        {
                            next = null
                        };
                        p1 = p1.next;
                        a = a.next;
                    }
                    else if (p1.val > p2.val)
                    {
                        a = new ListNode(p2.val)
                        {
                            next = null
                        };
                        p2 = p2.next;
                        a = a.next;
                    }

                    else
                    {
                        a = new ListNode(p1.val)
                        {
                            next = new ListNode(p2.val)
                        };
                        p1 = p1.next;
                        p2 = p2.next;
                        a.next.next = null;
                        a = a.next.next;
                    }
                }
            }
        }
    }
}
