using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Reciba 3 números por teclado y los imprima de menor a mayor*/
            int v1, v2, v3;
            Console.Write("Ingrese el primer valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer valor: ");
            v3 = int.Parse(Console.ReadLine());

            if (v1 < v2 && v1 < v3 && v2 < v3)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v1, v2, v3);
            }
            else if (v1 < v2 && v1 < v3 && v2 > v3)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v1, v3, v2);
            }
            else if (v2 < v1 && v2 < v3 && v1 < v3)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v2, v1, v3);
            }
            else if (v2 < v1 && v2 < v3 && v1 > v3)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v2, v3, v1);
            }
            else if (v3 < v1 && v3 < v2 && v2 < v1)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v3, v2, v1);
            }
            else if (v3 < v1 && v3 < v2 && v2 > v1)
            {
                Console.WriteLine("{0}<<{1}<<{2}", v3, v1, v2);
            }
        }
    }
}
