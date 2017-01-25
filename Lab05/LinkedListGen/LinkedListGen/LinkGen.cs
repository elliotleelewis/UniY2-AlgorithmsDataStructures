using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedListGen
{
    internal class LinkGen<T>
    {
        public LinkGen(T item)
        {
            Data = item;
            Next = null;
        }
        public LinkGen(T item, LinkGen<T> list)
        {
            Data = item;
            Next = list;
        }
        public LinkGen<T> Next { get; set; }
        public T Data { get; set; }
    }
}