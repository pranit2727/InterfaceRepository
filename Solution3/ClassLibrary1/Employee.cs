using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;


namespace ClassLibrary1
{
    public class Employee : IPerson,IEmployee
    {

        public int empId { get; set; }
        public string deptName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void personDeatils()
        {
            throw new NotImplementedException();
        }
        public void printDetails()
        {
            throw new NotImplementedException();
        }

        public void employeeDetails()
        {
            Console.WriteLine("Enter the deptname");
            this.deptName=Console.ReadLine();
            Console.WriteLine("Enter the departmentId");
            this.empId = Convert.ToInt32(Console.ReadLine());
        }

        public void printEmployeeDetails()
        {
            Console.WriteLine("The department is "+deptName+ " and employeeID id "+empId.ToString());
        }

       
    }
}
