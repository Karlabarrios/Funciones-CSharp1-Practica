using System;

namespace ExtraZ._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, s;
            Console.WriteLine("Ingrese el primer número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = int.Parse(Console.ReadLine());

            s = sumaResta(n1, ref n2);
            Console.WriteLine("La suma es de: " + s);
            Console.WriteLine("La resta del primero con el segundo es de: " + n2);
        }

        static int sumaResta(int a, ref int b)
        {
            int Suma;
            Suma = a + b;
            b = a - b;
            return Suma;
        }
    }
}
