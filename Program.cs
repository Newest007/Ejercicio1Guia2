using System;

namespace Ejercicio1Guía2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseLista listaPrincipal = new ClaseLista();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Title = "Ejercicio 1 Guía 2";
            int option;
            int valor, posicion;
            string siono;
            do
            {
                Console.WriteLine("==========================================");
                Console.WriteLine(" Seleccione el método que desea aplicar");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Insertar al Final");
                Console.WriteLine("2. Insertar al Frente");
                Console.WriteLine("3. Insertar en una posición en especifico");
                Console.WriteLine("4. Eliminar al Final");
                Console.WriteLine("5. Eliminar al Frente");
                Console.WriteLine("6. Mostrar datos");
                Console.WriteLine("7. Salir");
                Console.WriteLine("");
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
                            valor = int.Parse(Console.ReadLine());
                            Console.WriteLine("Seleccione la posición en la que desea añadir el dígito");
                            posicion = int.Parse(Console.ReadLine());
                            listaPrincipal.InsertarPosición(valor, posicion);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Eliminando el último dato..., presione cualquier tecla para continuar:");
                            Console.ReadLine();
                            listaPrincipal.EliminarAtras();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Eliminando el primmer dato..., presione cualquier tecla para continuar:");
                            Console.ReadLine();
                            listaPrincipal.EliminarAdelante();
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
                            Console.WriteLine("Saliendo del programa...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Opción no válida, seleccione otra opción");
                            break;
                        }

                }

                Console.WriteLine("Si desea añadir otro dígito presione cualquier tecla y si desea salir del programa solo presione 'n'");
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
