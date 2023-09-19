using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Ten
    {
        public static void TenProgram()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 5,6,7,8,9};
            for(int i=0;i<5;i++) { 
            for(int j = 0; j < 5; j++)
                {
                    if (arr1[i] == arr2[j])
                        Console.Write("Common element: "+arr1[i]); 
                }    
            }
        }
    }
}
