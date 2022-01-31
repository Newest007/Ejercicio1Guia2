using System;

namespace Ejercicio1Guía2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Ejercicio 1 Guía 2";
            int option;
            int valor1, valor2, valor3, valor4;
            string siono;
            do
            {
                Console.WriteLine("==========================================");
                Console.WriteLine(" Seleccione el método que desea aplicar");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Insertar al Frente");
                Console.WriteLine("2. Insertar al Final");
                Console.WriteLine("3. Insertar en una posición en especifico");
                Console.WriteLine("4. Eliminar al Frente");
                Console.WriteLine("5. Eliminar al final");
                Console.WriteLine("6. Mostrar datos");
                Console.WriteLine("7. Salir");
                option = int.Parse(Console.ReadLine());



                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el digíto que desea agregar al arreglo");
                            valor1 = int.Parse(Console.ReadLine());

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Saliendo del programa");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            break;
                        }

                }

                Console.WriteLine("Si desea añadir otro dígito presione 's', si desea salir presione 'n'");
                siono = Console.ReadLine();

            }
            while (siono != "n" && siono != "N");
            Console.WriteLine("\n");
            Console.WriteLine("====> Saliendo del programa, pase feliz día");
            Console.ReadKey();

        }
    }
}
