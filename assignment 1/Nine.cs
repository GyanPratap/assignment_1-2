using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Nine
    {
        public static void NineProgram()
        {
            int[] arr = new int[10] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            int[] unique = arr.Distinct().ToArray();
            Console.Write("Unique elements: ");
            foreach (int x in unique)
                Console.Write(x + " ");
        }
    }
}
