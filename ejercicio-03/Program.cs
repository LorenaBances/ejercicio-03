using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese el numero de notas: ");
            promedio = float.Parse(Console.ReadLine());
            Console.Write("Escriba la primera nota: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la segunda nota: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la tercera nota: ");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota: ");
            num4 = float.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3 + num4);
            promedio = (promedio / 4);

            Console.Write("El promedio es:" + promedio);
            Console.ReadKey();




        }
    }
}
