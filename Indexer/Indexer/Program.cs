using System;

namespace Indexer
{
    class students
    {
        private string[] name = new string[4];
        // private string sname;
        public string this[int i]
        {
            get { return name[i]; }
            set { name[i] = value;}
        }
        //indexer overloading
      /*  public string this[string name]
        {
            get
            {
                foreach (string s1 in name)
                {
                    if (s1.ToLower() == name.ToLower())
                    // Abc->abc == abc
                    {
                        return s1.ToUpper();
                    }
                }
                return null;
            }
        } */
        /* public void setname(string name)
         {
             this.sname = name;
         }
         public string getname()
         {
             return sname;
         }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            students slist = new students();
            slist[0] = "Anik";
            slist[1] = "Alok";
            slist[2] = "Anushree";
            slist[3] = "Adrita";
            for(int i=0; i<4; i++)
            {
                Console.Write(slist[i]+" ");
            }
           /* s.setname("Anik");
            Console.WriteLine(s.getname());*/
            Console.ReadKey();
        }
    }
}
