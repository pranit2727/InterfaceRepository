using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public interface IEmployee
    {
        int empId { set; get; }
        string deptName { set; get; }
        void employeeDetails();
        void printEmployeeDetails ();
    }
}
