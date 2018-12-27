using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person : IPerson
    {
        public string Name { get ; set; }
        public int Age { get; set; }

        public void personDeatils()
        {
            Console.WriteLine("Enter the name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            this.Age = Convert.ToInt32(Console.ReadLine()); 
        }

        public void printDetails()
        {
            Console.WriteLine("The name of person is " + Name + " age is " + Age.ToString());
        }
    }
}
