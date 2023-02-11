using System;

namespace Lab_3
{
    class Program
    {

        static void Main(string[] args)
        {
            int x =1, y =3,z=8;
            anik obj = new anik();
          
            obj.add(x,y,z);
            obj.mult(ref x, y, z);

            int k;
            obj.Out(out k);
            obj.Params(2, 0, 4, 2, 1, 3, 8, 1);
            string name="Anik";
            int sem=6;
            double cg=3.00;
            obj.Named(s: name, d: cg, i: sem);


            obj.jaggedArray();
            Console.ReadKey();
        }
    }
}
