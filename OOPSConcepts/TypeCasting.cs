using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    //Typecasting is used to assign a value of data type to another datatype.
    //There are two types of casting implicit and explicit.
    //Implicit:It means automatically converting a small type to a large type.
    //char=> int=> long=> float=> double
    //Explicit:It should be manually.
    //double=> float=> long=> int=> char
    
    public class TypeCasting
    {
        public void Method()
        {
            int value = 10;
            double valueOne = value;
            int valueTwo = 20;
            //long add=valueOne+valueTwo;
            Console.WriteLine(value);
            Console.WriteLine(valueOne);
            double valueThree = 10.5;
            int valueFour = (int)valueThree;
            Console.WriteLine(valueFour);
        }
    }
}
