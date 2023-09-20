using System;

namespace EjD4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, v = 0;

            Console.WriteLine("Ingrese un nro:");
            a = int.Parse(Console.ReadLine());

            positivoNegativoCero(a ,ref v);
            Console.WriteLine("La referencia del número es: " + v);
        }

        static void positivoNegativoCero(int n, ref int v)
        {
            if(n > 0)
                v = 1;
            else if(n < 0)
                v = -1;
            //else
                //v = 0;
        }
    }
}
