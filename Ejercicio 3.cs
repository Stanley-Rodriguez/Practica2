using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Reciba 3 números y confirme si el tercero resulta de multiplicar los dos primeros. */
            int v1, v2, v3;
            Console.Write("Ingrese el primer valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer valor: ");
            v3 = int.Parse(Console.ReadLine());

            var producto = v1 * v2;
            if (producto == v3)
            {
                Console.WriteLine("El 3er valor ingresado es el producto de {0} x {1}", v1, v2);
            }
            else
            {
                Console.WriteLine("El producto de los dos numeros no es igual al 3er valor ingresado");
            }
        }
    }
}
