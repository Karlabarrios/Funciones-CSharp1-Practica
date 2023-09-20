using System;

namespace EjB2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
                if(Par(n))
                    con++;
            }

            Console.WriteLine("La cantidad de números pares es de: " + con);
        }

        static bool Par(int a)
        {
            if(a % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
