using System;
namespace Generic
{
    class generic<t>
    {
        public t a;
        public void sett(t a)
        {
            this.a = a;
        }
        public t gett()
        {
            return a;
        }
    }
    class genericMethod{
        public void add<t,r>(t a, r b)
        {
            Console.WriteLine(a+" "+b);
        }
        }
class Program
    {
        static void Main(string[] args)
        {
            generic<int> gn1 = new generic<int>();
            generic<string> gn2 = new generic<string>();
            gn1.sett(5);
            gn2.sett(" Hello");
            Console.WriteLine(gn1.gett()+gn2.gett());

            genericMethod gm = new genericMethod();
            gm.add(5, 6);
            Console.ReadKey();
        }
    }
}
