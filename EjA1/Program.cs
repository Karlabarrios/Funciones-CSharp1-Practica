using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, TotalPagar;

            Console.WriteLine("Ingrese el precio del producto: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad comprada del producto:");
            n2 = int.Parse(Console.ReadLine());

            TotalPagar = Producto(n1, n2);

            Console.WriteLine("El total a pagar es de: " + TotalPagar);
            
        }

        static int Producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
