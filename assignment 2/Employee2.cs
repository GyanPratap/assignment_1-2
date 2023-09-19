using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal partial class Employee2
    {
        int baseSalary,HRA,DA;
        void read(int baseSalary,int HRA,int DA)
        {
            this.baseSalary = baseSalary;
            this.HRA = HRA;
            this.DA = DA;
        }
    }
}
