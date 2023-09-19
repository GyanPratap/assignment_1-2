using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal partial class Employee2
    {
        string EmpName,Email; long ContactNumber;
        void read(string EmpName,string Email,long ContactNumber)
        {
            this.EmpName=EmpName;
            this.Email=Email;
            this.ContactNumber=ContactNumber;
        }
    }
}
