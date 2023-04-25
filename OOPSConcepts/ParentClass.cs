using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //
    public class ParentClass:BaseClass
    {
       public ParentClass() 
        {
            Console.WriteLine("This is a parent class");
        }
        public void Class()
        {
            Console.WriteLine("This is my method for parent class");
        }

    }
    public class BaseClass
    {
        public string name;

        public void TestName() 
        {
            Console.WriteLine("This is a base class");
        }
    }
}
