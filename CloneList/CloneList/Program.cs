using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneList
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static ComplexListNode Clone(ComplexListNode n)
        {
            Stack<ComplexListNode> s = new Stack<ComplexListNode>();
            while (n != null)
            {
                ComplexListNode n2 = new ComplexListNode();
                n2.value = n.value;
                s.Push(n2);
                n = n.Sibling;

            }

            ComplexListNode temp = null;

            while (s.Count > 0)
            {
                ComplexListNode n3 = s.Pop();
                n3.Next = temp;
                temp = n3;
            }

            return temp;
        }
    }
}
