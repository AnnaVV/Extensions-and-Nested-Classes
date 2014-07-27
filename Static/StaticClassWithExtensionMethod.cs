using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class  StaticClassWithExtensionMethod
    {
        public static int[] MyAscSort(this int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            return array;
        }

        public static void PrintArray(this int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
