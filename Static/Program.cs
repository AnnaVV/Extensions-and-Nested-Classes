using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[7] { 4, 2, 18, 48, 34, 200, 41 };

            int [] sortedArray = someArray.MyAscSort();

            sortedArray.PrintArray();

            Console.ReadLine();
        }
    }
}
