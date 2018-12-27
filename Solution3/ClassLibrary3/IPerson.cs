using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public interface IPerson
    {
        string Name { set; get; }
        int Age { set; get; }
        void personDeatils();
        void printDetails();
    }
}
