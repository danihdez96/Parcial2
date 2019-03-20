using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int opc, num1, num2, resul;

        public void Operaciones1()
        {
            Console.WriteLine("Presione 1 para multiplicar los numeros");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese un numero entero cualquiera");
                    num1 = int.Parse(Console.ReadLine());
                    if (num1 != 0)
                    {
                        Console.WriteLine("Ingrese otro numero entero");
                        num2 = int.Parse(Console.ReadLine());
                        resul = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es: " + resul);
                    }
                    else
                    {
                        Console.WriteLine("El producto de 0 por cualquier otro numero es 0");
                    }
                    break;
            }
        }


        public int num3, num4, opc1;
        public double resul1;
        public void Division()
        {
            Console.WriteLine("Presione 2 para dividir los numeros");
            opc1 = int.Parse(Console.ReadLine());
            switch (opc1)
            {
                case 2:
                    Console.WriteLine("Ingrese un numero entero cualquiera");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un otro numero entero cualquiera");
                    num4 = int.Parse(Console.ReadLine());
                    if (num3 !=0 && num4 != 0)
                    {
                        resul1 = num3 / num4;
                        Console.WriteLine("El resultado de la multiplicacion es: " + resul1);
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero");
                    }
                    break;
            }

        }


        string nom;

        public void ImpNombres()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite los nombres de los alumnos");
                nom = Console.ReadLine();
                Console.WriteLine(nom);
            }
        }


        int edad, c1=0;

        public void ImpEdades()
        {
            do
            {
                Console.WriteLine("Digite 5 edades");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine(edad);
            } while (c1 <= 5);
        }
    }
}
