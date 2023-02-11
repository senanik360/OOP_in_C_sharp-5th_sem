using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Customer : Person
    {

        //string name(private/protected) //inherited
        //string dob(private/protected) //inherited

        private Account acc;
        //(private/protected)
//Constructors, Properties & Methods
        public Customer()
        {
            Console.WriteLine("Empty Constructor called from Customer class\n");

        }
        public Customer(string name, string dob, Account acc) : base(name, dob)
        {
            Console.WriteLine("Params Constructor of Customer class\n");

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
