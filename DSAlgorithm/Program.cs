using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Loading");
            Console.Write("Enter the size of the stack: ");
            int size =  Convert.ToInt32(Console.ReadLine());
            if(size > 0)
            {
                Stack stack = new Stack(size);

                for(int i=0; i<size; i++)
                {
                    Console.WriteLine(size);
                    Console.Write("Enter the numweric value to the Stack: ");
                    long c = Convert.ToInt64(Console.ReadLine());
                    stack.push(c);
                    
                 
                }

            }


            Console.ReadKey();
        }

       
    }
}
