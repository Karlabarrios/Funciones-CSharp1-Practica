using System;

namespace EjC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu, b2, promedio;
            int con = 0, acuPrimos = 0;
            
            Console.WriteLine("Ingrese un número:");
            nu = int.Parse(Console.ReadLine());

            while(nu != 0)
            {
                b2 = Primo(nu);
                if(b2 == 1)
                {
                    con++;
                    acuPrimos += nu;
                }

                Console.WriteLine("Ingrese un número:");
                nu = int.Parse(Console.ReadLine());
            }

            promedio = acuPrimos / con;
            Console.WriteLine("El promedio de los números primos es de: " + promedio);
        }

        static int Primo(int n)
        {
            int b = 0, con = 0;
            for(int x = 1; x <= n; x++)
            {
                if((n % x) == 0)
                    con++;
            }
            if(con == 2)
                b = 1;
            return b;
        }
    }
}
