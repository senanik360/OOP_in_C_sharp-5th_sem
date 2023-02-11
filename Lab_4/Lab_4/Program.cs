using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ae = new Account(1223, 2346.450, "Emp1");
            Employee e1 = new Employee();
            e1.setName("Devid");
            e1.setDob("23th January");
            e1.setAcc(ae);
            e1.display();
            Console.WriteLine();
            Account ae1 = new Account(1233, 3456.534, "Emp2");
            Employee e2 = new Employee("Smith","4th February",ae1);
            Console.WriteLine();

            e2.display();
            Console.WriteLine();



            Account ac = new Account(9345, 7554.785, "Cus1");
            Customer c1 = new Customer();
            c1.setName("Ponting");
            c1.setDob("8th January");
            c1.setAcc(ac);
            c1.display();
            Console.WriteLine();
            Account ac1 = new Account(4566, 3456.534, "Cus2");
            Customer c2 = new Customer("Stoinis","3rd March",ac1);
            c2.display();


            Console.ReadKey();

        }
    }
    }

