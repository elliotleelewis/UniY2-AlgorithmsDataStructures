using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    internal class LinkList
    {
        private Link list = null;
        public void AddItem(int item)
        {
            list = new Link(item, list);
        }
        public string DisplayItems()
        {
            var temp = list;
            var buffer = "";
            while (temp != null) {
                buffer += temp.Data + ", ";
                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems()
        {
            var temp = list;
            var count = 0;
            while (temp != null) {
                count++;
                temp = temp.Next;
            }
            return count;
        }
        public bool IsPresentItem(int item)
        {
            var temp = list;
            while (temp != null) {
                if (temp.Data == item) {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public void RemoveItem(int item)
        {
            var temp = list;
            while (temp.Next != null) {
                if (temp.Next.Data == item) {
                    temp.Next = temp.Next.Next;
                }
                temp = temp.Next;
            }
        }
        public void InsertInOrder(int item)
        {
            var temp = list;
            while (temp.Next != null) {
                if (temp.Data <= item && temp.Next.Data >= item) {
                    temp.Next = new Link(item, temp.Next);
                    return;
                }
                temp = temp.Next;
            }
        }
    }
}