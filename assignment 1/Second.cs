using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class Second
    {
        public static void SecondProgram()
        {
            float[] arr = new float[5] { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f };
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The average of array elements is: " + (sum/5));
        }
    }
}
