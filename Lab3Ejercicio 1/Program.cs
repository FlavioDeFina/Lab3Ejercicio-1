using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tipo de fruta que desea transportar: ");
            Console.WriteLine("N: Naranja");
            Console.WriteLine("F: Fresa");
            Console.WriteLine("M: Mango");
            string fruta = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de cajas de fruta que va a transportar: ");
            int cajas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la distancia en kilometros que va a recorrer: ");
            float kilometros = float.Parse(Console.ReadLine());

            float precio = 0f;

            if (fruta == "N") 
            {
                if (kilometros < 30)
                {
                    precio = 2 * cajas;
                }
                else if (kilometros > 30) 
                {
                    precio = 4 * cajas;
                }
                Console.WriteLine("El precio a pagar es de:"+precio);
            }
            if (fruta == "F")
            {
                if (kilometros < 30)
                {
                    precio = 6 * cajas;
                }
                else if (kilometros > 30)
                {
                    precio = 9 * cajas;
                }
                Console.WriteLine("El precio a pagar es de:" + precio);
            }
            if (fruta == "M")
            {
                if (kilometros < 30)
                {
                    precio = 3 * cajas;
                }
                else if (kilometros > 30)
                {
                    precio = 5 * cajas;
                }
                Console.WriteLine("El precio a pagar es de:" + precio);
            }
            Console.ReadKey();
        }
    }
}