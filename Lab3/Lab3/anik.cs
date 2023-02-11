using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class anik
    {
        public string name;
        private int age;
        private double cgpa;
        protected string semester;
        internal string program;
        public string varsity;

        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setSemester(string semester)
        {
            this.semester = semester;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public void setVarsity(string varsity)
        {
            this.varsity = varsity;

        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public string getSemester()
        {
            return semester;
        }
        public string getProgram()
        {
            return program;
        }
        public double getCgpa()
        {
            return cgpa;
        }
        public string getVarsity()
        {
            return varsity;
        }

        //empty
        public anik()
        {
            Console.WriteLine("\t\t\t\tEmpty");

        }

        //parameterized
        public anik(string name, int age, string semester, string program, double cgpa, string varsity)
        {
            Console.WriteLine("\t\t\t\tParameterized constructor is called.");
            this.name = name;
            this.age = age;
            this.semester = semester;
            this.program = program;
            this.cgpa = cgpa;
            this.varsity = varsity;
        }

        //copy constructor
        public anik(anik ob)
        {
            age = ob.age;
            name = ob.name;
            semester = ob.semester;
            program = ob.program;
            cgpa = ob.cgpa;
            varsity = ob.varsity;

            Console.WriteLine("\t\t\t\tCopy constructor is called");
        }
        //static constructor
        static anik()
        {
            Console.WriteLine("\t\t\t\tStatic Constructor\n");
        }

        public void show()
        {
            Console.WriteLine("\tName : " + name);
            Console.WriteLine("\tAge : " + age);
            Console.WriteLine("\tProgram : " + program);
            Console.WriteLine("\tSemester : " + semester);
            Console.WriteLine("\tCGPA : " + cgpa);
            Console.WriteLine("\tUniversity : " + varsity);

        }

    }
}
