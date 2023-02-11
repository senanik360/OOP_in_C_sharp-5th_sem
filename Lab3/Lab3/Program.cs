using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            anik ob1 = new anik();
            ob1.name = "Sen ";
            ob1.setAge(21);
            ob1.setProgram(" CSE");
            ob1.setCgpa(3.92);

            Console.WriteLine("\tName : "+ob1.getName());
            Console.WriteLine("\tProgram : "+ob1.getProgram());
            Console.WriteLine("\tCGPA : "+ob1.getCgpa());

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            anik ob2 = new anik("Anik Sen", 21, "6th", "CSE", 3.92, "AIUB"); //(string name, int age, string semester, string program, double cgpa, string varsity)
            ob2.show();

            Console.WriteLine(" ");
      
          

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            anik ob3 = new anik(ob2);
            ob3.show();

            Console.ReadKey();


        }
    }
}
