using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //using reference  of the Iperson creating instance of the employee
            IPerson person = new Person();
            person.personDeatils();
            person.printDetails();
         

            Console.WriteLine("press any key \n");
            Console.ReadKey();

            //using reference  of the IEmployee creating instance of the employee
            IEmployee emp = new Employee();
            emp.employeeDetails();
            emp.printEmployeeDetails();


            //Console.WriteLine("the deptname is "+person.Name+ "and id is"+person.Age + "");
            Console.ReadKey();

        }
    }
}
