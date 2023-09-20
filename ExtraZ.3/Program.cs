using System;

namespace ExtraZ._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conImp = 0;
            int MaxP = 0, MinP = 0;
            bool BMax = false, BMin = false;
            bool bp, pri;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while(n != 0)
            {
                bp = Par(n);
                if(bp)
                {
                    if(!BMax)
                    {
                        MaxP = n;
                        BMax = true;
                    }
                    else if(n > MaxP)
                        MaxP = n;
                }
                else{
                    conImp++;
                }

                pri = Primo(n);
                if(pri)
                {
                    if(!BMin)
                    {
                        MinP = n;
                        BMin = true;
                    }
                    else if(n < MinP)
                        MinP = n;
                }

                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La cantidad de impares es de: " + conImp);
            Console.WriteLine("El mayor de los pares es: " + MaxP);
            Console.WriteLine("El menor de los primos es: " + MinP);
        }

        static bool Par(int a)
        {
            if(a % 2 == 0)
                return true;
            else
                return false;
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
