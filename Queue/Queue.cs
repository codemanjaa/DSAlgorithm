using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private int size;
        private int front;
        private int last;
        private long[] queueArray;
        private int nItems;

        public Queue(int size)
        {
            queueArray = new long[size];
            this.size = size;
            nItems = 0;
            front = 0;
            last = -1;

        }


        public void insert(long element){

            if (isFull())
            {
                Console.WriteLine("Queue is Full...");
            }
            else { 
            last++;
            queueArray[last] = element;
            nItems++;
            }
        }

        public long remove()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is EMPTY...");
                return -1;
            }
            else { 
            long temp = queueArray[front];
            nItems--;

            return temp;
            }
        }

        public void view()
        {
            Console.Write("[ ");
            for(int i=0; i< queueArray.Length; i++)
            {
                Console.Write(queueArray[i] + " ");
            }
            Console.Write("]");
        }

        public  bool isEmpty()
        {
            return (nItems == 0);
        }

        public bool isFull()
        {
            return (size == nItems);
        }
    }
}
