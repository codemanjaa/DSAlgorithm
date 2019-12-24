using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    public class Stack
    {
        private int top;
        private int maxSize;
        private long[] stackArray;

        public Stack(int size)
        {
            this.maxSize = size;
            top = -1;
            stackArray = new long[maxSize];
        }

        public void push(long element)
        {
            top++;
            stackArray[top] = element;
        }

        public long pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("This is EMPTY");
                return top;
                
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];

                
            }
            
        }

        public bool isEmpty()
        {
            return (top == -1);
        }


        public bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
