using System;

namespace EjC3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio;
            int con = 0, acuPrimos = 0;

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                if(Primo(n))
                {
                    con++;
                    acuPrimos += n;
                }
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            promedio = acuPrimos / con;
            Console.WriteLine("El promedio de los números primos es: " + promedio);
        }

        static bool Primo(int a)
        {
            int con = 0;
            for(int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                    con++;
            }

            if(con == 2)
                return true;
            else
                return false;
        }
    }
}
