using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Third
    {
        public static void ThirdProgram()
        {
            int[] arr = new int[5] {1,2,3,4,5};
            int large = 0;
            for(int i = 0; i < 5; i++)
            {
                if (large < arr[i])
                        large = arr[i];
            }
            Console.WriteLine("The largest element is: "+large);
        }
    }
}
