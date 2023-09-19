using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal partial class Person
    {
        public void display()
        {
            Console.WriteLine("The full name of the person is: " + firstName + " " + lastName);
        }
    }
}
