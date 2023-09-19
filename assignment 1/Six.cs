using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Six
    {
        public static void Sixthprogram()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Enter factor to multiply: ");
            int factor=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 5; i++)
            {
                arr[i] *= factor;
            }
            foreach(int x in arr)
                Console.Write(x+" ");   
        }
    }
}
