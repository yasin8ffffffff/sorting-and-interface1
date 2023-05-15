using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sorting_and_interface1
{
    class sort : Isorting
    {
        public void Main()
        {
            void sortanArray()
            {
                int[] intArray = new int[] { 3, 5, 7, 9, 4, 15, 10, 6, 8, 1, 11, 12, 2, 13, 14 };
                Console.WriteLine("original Array");
                foreach (int i in intArray)
                {
                    Console.Write(i +  " ");
                }
                Console.WriteLine();
                Console.WriteLine("increasing order");
                Array.Sort(intArray);
                foreach (int i in intArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("decreasing order");
                Array.Reverse(intArray);
                foreach (int i in intArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }

        public void SortanArray()
        {
            throw new NotImplementedException();
        }
    }
  
}
