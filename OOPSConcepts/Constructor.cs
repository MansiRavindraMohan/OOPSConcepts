using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class Constructor:InterfaceType
    {
        public ClassName demo;
        public Constructor() 
        {
            Console.WriteLine("Helloworld");
        }
        public Constructor(string name, ClassName demo)
        {
            Console.WriteLine(name);
            this.demo = demo;
        }

        public void WithoutImplementationMethod()
        {
            Console.WriteLine("hiii all");
            //throw new NotImplementedException();
        }
    }
}
