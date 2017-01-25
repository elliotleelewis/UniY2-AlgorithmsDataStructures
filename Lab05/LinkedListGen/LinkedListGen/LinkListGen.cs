using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedListGen
{
    internal class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }
        public string DisplayList()
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
        public bool IsPresentItem(T item)
        {
            var temp = list;
            while (temp != null) {
                if (temp.Data.Equals(item)) {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public void RemoveItem(T item)
        {
            var temp = list;
            while (temp.Next != null) {
                if (temp.Next.Data.Equals(item)) {
                    temp.Next = temp.Next.Next;
                }
                temp = temp.Next;
            }
        }
        public void AppendItem(T item)
        {
            if (list == null) {
                list = new LinkGen<T>(item);
                return;
            }
            var temp = list;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            temp.Next = new LinkGen<T>(item);
        }
        public void Concat(LinkListGen<T> list2)
        {
            var temp = list2.list;
            while (temp != null) {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }
        public void Copy(LinkListGen<T> list2)
        {
            list = null;
            Concat(list2);
        }
        public void InsertInOrder(T item)
        {
            var temp = list;
            while (temp.Next != null) {
                if (temp.Data.CompareTo(item) <= 0 && temp.Next.Data.CompareTo(item) >= 0) {
                    temp.Next = new LinkGen<T>(item, temp.Next);
                    return;
                }
                temp = temp.Next;
            }
        }
        public void Sort()
        {
            var sortList = new List<T>();
            var temp = list;
            while (temp != null) {
                sortList.Add(temp.Data);
                temp = temp.Next;
            }
            sortList.Sort();
            list = null;
            foreach (var item in sortList) {
                AppendItem(item);
            }
        }
    }
}