using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Five
    {
        public static void FifthProgram()
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5 ,6};
            int temp = 0,j=(6-1);
            for (int i = 0; i < 6; i++)
            {
                    if (i <= j)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j]=temp;
                    }
                j--;
            }
            Console.WriteLine("The reverse of the array is: ");
            foreach(int x in arr) Console.Write(x+" ");
        }
    }
}
