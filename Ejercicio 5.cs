using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Reciba un usuario y una contraseña. Si el usuario ingresa sus datos mal 3 veces debe notificársele que ha intentado iniciar sesión 3 veces.
                * Que contacte al administrador.*/
            string[] login = new string[4];
            int n = 0;
            login[0] = "stanley";
            login[1] = "1234";
            while (true)
            {
                Console.Clear();
                Console.Write("Ingrese el usuario: ");
                login[2] = Console.ReadLine();
                Console.Write("Ingrese la contrasena: ");
                login[3] = Console.ReadLine();

                if ((login[0] == login[2]) && (login[1] == login[3]))
                {
                    Console.WriteLine("Bienvenido " + login[0] + " al sistema");
                    break;
                }
                else
                {
                    Console.WriteLine("El usuario es incorrecto o no esta registrado");
                    n++;
                    Console.ReadLine();
                    if (n == 3)
                    {
                        Console.WriteLine("Ha exedido el total de intentos, contacte al administador...");
                        break;

                    }
                }
            }
        }
    }
}
