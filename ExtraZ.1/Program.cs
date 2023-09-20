using System;

namespace ExtraZ._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Monto1, MontoxPago = 0;
            int CantPagos1;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese el monto de la venta:");
                Monto1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pagos:");
                CantPagos1 = int.Parse(Console.ReadLine());

                MontoxPago = Pagos(Monto1, CantPagos1);
                Console.WriteLine("La cantidad de pagos que se hicieron fue de: " + CantPagos1 + " con un monto de: $" + MontoxPago + " cada uno.");

            }
        }

        static float Pagos(float Monto, int CantPagos)
        {
            float MontoperPago = Monto / CantPagos;
            return MontoperPago;
        }
    }
}
