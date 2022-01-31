using System;

namespace Ejercicio1Guía2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseLista listaPrincipal = new ClaseLista();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Ejercicio 1 Guía 2";
            int option;
            int valor;
            string siono;
            do
            {
                Console.WriteLine("==========================================");
                Console.WriteLine(" Seleccione el método que desea aplicar");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Insertar al Final");
                Console.WriteLine("2. Insertar al Frente");
                Console.WriteLine("3. Insertar en una posición en especifico");
                Console.WriteLine("4. Eliminar al Frente");
                Console.WriteLine("5. Eliminar al final");
                Console.WriteLine("6. Mostrar datos");
                Console.WriteLine("7. Salir");
                Console.WriteLine("\n");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el digíto que desea agregar al arreglo");
                            valor = int.Parse(Console.ReadLine());
                            listaPrincipal.InsertarFinal(valor);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el dígito que desea agregar al arreglo");
                            valor = int.Parse(Console.ReadLine());
                            listaPrincipal.InsertalInicio(valor);
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
                            listaPrincipal.ImprimirLista();
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

                Console.WriteLine("Si desea añadir otro dígito presione cualquier tecla");
                Console.WriteLine("Si desea salir de programa presione 'n' ");
                siono = Console.ReadLine();
                Console.Clear();

            }
            while (siono != "n" && siono != "N");
            Console.WriteLine("\n");
            Console.WriteLine("====> Saliendo del programa, pase feliz día");
            Console.ReadKey();

        }
    }
}
