using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class ValueType
    {
        //In value type two types are there 1)built in type 2)user-defined type.
        //Built-in= int, long,float, double, byte ,decimal, short, char, bool
        //User-defined type=struct and enum
        //It will store in a stack memory.
        public void MethodValueType()
        {
            //num_one and num_two variables are the value types..
            int num_one = 12;
            int num_two=num_one;
            num_two++;
            Console.WriteLine(num_one);
            Console.WriteLine(num_two);
        }
    }
}
