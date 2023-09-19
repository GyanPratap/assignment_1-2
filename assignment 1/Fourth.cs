using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Fourth
    {
        public static void FourthProgram()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5};
            int Even = 0, Odd=0;
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] % 2 == 0)
                    Even++;
                else
                    Odd++;
            }
            Console.WriteLine("The Even elements is: "+Even+"and the odd elements is: "+Odd);
        }
    }
}
