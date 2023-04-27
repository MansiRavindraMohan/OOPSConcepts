using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class Encapsulation
    {
        //It will hide sensitive data from the user.
        //declare field or variable should be private.
        //get: it is read only and set: it is used to set.

        private string name = "Raj";//defined field in private
        public string Name //property
        {
            get 
            { 
                return name; 
            }
            set
            {
                name = value;//name=value:it will set or assign value to name.
            }
        }
        public int RollNo
        {
            get;set;
        }
    }
}
