using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class VairableEx
    {
        //Readonly and constant 

        public readonly string FirstName;
        public const string LASTNAME ="jose" ;


        //parameter less and parametized constructor 


        public VairableEx()
        {
            FirstName = "Sachin";
          //  LastName = "hello";

        }
        public VairableEx(string firstName, string lastName)
        {
            FirstName = firstName;
           // LastName = lastName;
        }
        public void PrintName()
        {
            Console.WriteLine(LASTNAME);
        }


    }
}
