using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Employee : Person
    {
        
       //string name (private/protected) //inherited
            // string dob (private/protected) //inherited
          private Account acc ;//(private/protected)
           // Constructors, Properties & Methods
             public Employee()
        {
            Console.WriteLine("Empty Constructor called from Employee class");
        }
        public Employee (string name, string dob, Account acc) : base (name, dob)
        {
            Console.WriteLine("Perams Constructor called from Employee  class");

            this.acc = acc;
        }
         public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        public void display()
        {
            Console.WriteLine("\tName : " + getName());
            Console.WriteLine("\tDate of Birth : " + getDob());
            acc.displayAccDetails();
        }
         
    }
}
