using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneList
{
    class ComplexListNode
    {

        public ComplexListNode()
        {
        }

        public object value            {get; set;}
        public ComplexListNode Next    {get; set;}
        public ComplexListNode Sibling {get; set;}
    }
}
