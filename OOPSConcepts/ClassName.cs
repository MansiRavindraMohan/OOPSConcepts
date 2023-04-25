using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class ClassName:InterfaceType
    {
        //Non-parameterised method
        public void PrintName()
        {
            Console.WriteLine("Mansi Mohan");
        }
        //Parameterised method
        public void PrintType(string name)
        {
            Console.WriteLine(name);
        }

        public void Number()
        {
            Console.WriteLine("The number is 122");
        }
        public void NumberTwo(int num,int num1,int num2) 
        {
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public void WithoutImplementationMethod()
        {
            //throw new NotImplementedException();
            Console.WriteLine("This is my class");
        }
    }
}
