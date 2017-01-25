using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class IntQueue
    {
        private readonly int maxsize = 10;
        private readonly int[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;
        public IntQueue()
        {
            store = new int[maxsize];
        }
        public IntQueue(int size)
        {
            maxsize = size;
            store = new int[maxsize];
        }
        public void Enqueue(int value)
        {
            numItems++;
            store[tail] = value;
            if (++tail == maxsize) {
                tail = 0;
            }
        }
        public int Dequeue()
        {
            numItems--;
            var headItem = store[head];
            if (++head == maxsize) {
                head = 0;
            }
            return headItem;
        }
        public int Peek()
        {
            return store[tail];
        }
        public bool IsEmpty()
        {
            return numItems == 0;
        }
        public bool IsFull()
        {
            return numItems == maxsize;
        }
        public int Count()
        {
            return numItems;
        }
    }
}