using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal partial class Employee2
    {
        void display()
        {
            Console.WriteLine("Employee name is: "+EmpName);
            Console.WriteLine("Employee email is: " + Email);
            Console.WriteLine("Employee contact number is: "+ContactNumber);
            Console.WriteLine("Employee gross salary is: " + baseSalary);
            Console.WriteLine("Employee HRA is: "+HRA);
            Console.WriteLine("Employee DA is: " + DA);
            Console.WriteLine("Employee gross salary is: " + (baseSalary + HRA + DA));
        }
    }
}
