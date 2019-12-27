using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue is loading...");
            Console.Write("Enter the size of the Queue: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Queue queue = new Queue(size);
            for(int i=0; i<size; i++)
            {
                Console.Write("Enter the long value: ");
                queue.insert(Convert.ToInt64(Console.ReadLine()));

            }
            queue.insert(100);
            queue.view();
            queue.remove();
            Console.ReadKey();
        }
    }
}
