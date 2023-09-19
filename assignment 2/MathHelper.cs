using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal static class MathHelper
    {
        static int CalculateAverage(int[] arr)
        {
            int sum=0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum/arr.Length;
        }
        /*static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter values for array: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            int avg=MathHelper.CalculateAverage(arr);
            Console.WriteLine("The average is: "+avg);
        }*/
    }
}
