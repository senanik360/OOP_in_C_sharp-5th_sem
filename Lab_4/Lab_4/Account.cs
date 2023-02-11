using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Account
    {   
        private int account_id ;// (private/protected)
        private double amount;// (private/protected)
        private string accType;// (private/protected)
        //Constructors, Properties & Methods
        public Account (int account_id, double amount, string accType)
        {
            this.account_id = account_id;
            this.amount = amount;
            this.accType = accType;
        }
        public void displayAccDetails()
        {
            Console.WriteLine("\tAccount id : " + account_id);
            Console.WriteLine("\tAmount : " + amount);
            Console.WriteLine("\tAccount type : " + accType);
        }
    }
}
