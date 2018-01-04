using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Sorting_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            CArray nums = new CArray(10);
            Random rand = new Random(100);

            for (int i = 0; i < 10; i++)
            {
                nums.Insert((int)(rand.NextDouble() * 100));
            }
            Console.WriteLine("Before sorting: ");
            nums.DisplayElemnts();
            // Console.WriteLine("During sorting: ");
            // nums.BubbleSort();
            // Console.WriteLine("After Bubble  sorting: ");
            //  nums.DisplayElemnts();

            // Console.WriteLine("During sorting: ");
            // nums.SelectionSort();
            // Console.WriteLine("After Selection  sorting: ");
            // nums.DisplayElemnts();

            Console.WriteLine("During sorting: ");
            nums.InsertionSort();
             Console.WriteLine("After Insertion  sorting: ");
             nums.DisplayElemnts();
            Console.ReadKey();
        }
    }
}
