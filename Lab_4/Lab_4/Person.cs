using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Person
    {
        //Field variables:
        private string name; // (private/protected)
        private string dob; // (private/protected)
            //Constructors, Properties & Methods
             public Person()
        {
            Console.WriteLine("Empty Constructor called from person class\n");
        }
            public Person (string name, string dob)
        {
            Console.WriteLine("Perams Constructor called from person class\n");

            this.name = name;
            this.dob = dob;
        }
        public void setName (string name)
        {
            this.name = name;
        }
            public void setDob (string dob)
        {
            this.dob = dob;
        }
           public string getName()
        {
            return name;
        }
            public string getDob()
        {
            return dob;
        }
    }
}
