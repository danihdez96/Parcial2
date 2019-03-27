using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            obj1.Operaciones1();

            Class1 obj2 = new Class1();
            obj2.Division();


            Class1 obj3 = new Class1();
            obj3.ImpNombres();

            Class1 obj4 = new Class1();
            obj4.ImpEdades();

            Console.ReadKey();
        }
    }
}
