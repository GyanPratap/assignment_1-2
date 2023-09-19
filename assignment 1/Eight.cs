using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Eight
    {
        public static void EightProgram()
        {
            int[] arr = new int[5] { 1, 5, 2, 4, 3 };
            Array.Sort(arr);
            Console.WriteLine("The second smallest number is: " + arr[1]);
        }
    }
}
