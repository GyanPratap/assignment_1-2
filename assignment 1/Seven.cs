using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Seven
    {
        public static int SevenProgram()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Enter value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int index=0;
            for(int i = 0; i < 5; i++)
            {
                if (arr[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
