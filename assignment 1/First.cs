using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPrograms
{
    internal class First
    {
        public static void FirstProgram()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum of array elements is: " + sum);
        }
        static void Main(string[] args)
        {
            //FirstProgram();
            //Second.SecondProgram();
            //Third.ThirdProgram();
            //Fourth.FourthProgram();
            //Five.FifthProgram();
            //Six.Sixthprogram();
            //Console.Write("The index of element is: "+Seven.SevenProgram());
            //Eight.EightProgram();
            //Nine.NineProgram();
            Ten.TenProgram();
            Console.Read();
        }
    }
}
