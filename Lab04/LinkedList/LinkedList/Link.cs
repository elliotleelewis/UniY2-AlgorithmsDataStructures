using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    internal class Link
    {
        public Link(int item)
        {
            Data = item;
            Next = null;
        }
        public Link(int item, Link list)
        {
            Data = item;
            Next = list;
        }
        public int Data { set; get; }
        public Link Next { set; get; }
    }
}