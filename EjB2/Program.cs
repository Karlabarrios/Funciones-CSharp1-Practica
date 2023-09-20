using System;

namespace EjB
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b2;
            int con = 0;

            for(int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                b2 = Par(n);
                if(b2 == 1)
                    con++;
            }

            Console.WriteLine("La cantidad de números pares es de: " + con);
        }

        static int Par(int a)
        {
            int b = 0;
            if((a % 2) == 0)
                b = 1;

            return b;
        }
    }
}
