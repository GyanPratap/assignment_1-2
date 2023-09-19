using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class Employee
    {
        String name; int age; float salary;
        public void display(String name, int age, float salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            Console.WriteLine("The name of the employee is: " + name);
            Console.WriteLine("The age of the employee is: "+age);
            Console.WriteLine("The salary of the employee is: " + salary);
        }
        /*static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.display("Akash singh",21,50000);
        }*/
    }
}
