using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1Guía2
{
    class ClaseLista
    {

        public ListaNodo primerNodo;
        public ListaNodo ultimoNodo;
        int tamañoLista = 0;

        //Constructor por defecto
        public ClaseLista()
        {
            primerNodo = ultimoNodo = null;
        }

        //Método para verificar si la lista esta vacia
        public bool EstaVacia()
        {
            return primerNodo == null;
        }

        //Método que inserta al final de la lista
        public void InsertarFinal(int digito)
        {
            ListaNodo auxiliar = new ListaNodo(); //Se crea un nodo temporal que aún no pertenece a la lista
            auxiliar.Datos = digito;
            auxiliar.Siguiente = null;
            if (EstaVacia())//Si la lista esta vacia:
            {
                primerNodo = ultimoNodo = auxiliar;
                tamañoLista = tamañoLista + 1;
            }
            else
            {
                // Puntero
                //   1    ,   2   ,   3   , 4  ,null
                ListaNodo puntero; //Nodo para recorrer la lista de manera que la cabecera no se mueva
                puntero = primerNodo;
                while(puntero.Siguiente!=null) //Se hará si en cierto caso el proximo dato no es null
                {
                    puntero = puntero.Siguiente; //Ira recorriendo la lista de nodos hasta topar con null
                }
                puntero.Siguiente = auxiliar;
                tamañoLista = tamañoLista + 1;
            }
        }
        //============================================================//

        //  Método para ingresar un valor al principio, de tal manera que la cabecerá cambie
        public void InsertalInicio(int digito)
        {
            ListaNodo auxiliar = new ListaNodo();
            auxiliar.Datos = digito;
            auxiliar.Siguiente = null;

            if(EstaVacia())
            {
                primerNodo = ultimoNodo = auxiliar;
                tamañoLista = tamañoLista + 1;
            }
            else
            {
                ListaNodo puntero; //Usado para recorrer la lista
                puntero = primerNodo;
                primerNodo = auxiliar;
                auxiliar.Siguiente = puntero; //Lo que hace es modificar la cabecera de tal manera que el auxiliar se poné como
                tamañoLista = tamañoLista + 1;//primer nodo: valor siguiente del auxiliar será el puntero
            }
        }
        //=======================================================================================//

        //Método para insertar en una posición en concreto de la lista
        public void InsertarPosición(int digito, int posicion)
        {
            ListaNodo auxiliar = new ListaNodo();
            auxiliar.Datos = digito;
            auxiliar.Siguiente = null;

            if(EstaVacia()) //Si la lista esta vacía
            {
                Console.WriteLine("\nLa lista está vacía, el dato se ingresara en la 1° posición");
                Console.WriteLine("");
                primerNodo = auxiliar;
                tamañoLista = tamañoLista + 1;
            }
            else
            {
                ListaNodo Puntero;
                Puntero = primerNodo;

                if (posicion > tamañoLista)
                {
                    Console.WriteLine("\nPosición fuera de los rangos de la lista!, el dígito se colocara al final de la lista");
                    Console.WriteLine("\n");
                }

                if (posicion == 1) //Si la posición es 1 se inserta en la cabecera
                {
                    primerNodo = auxiliar;
                    auxiliar.Siguiente = Puntero;
                }
                else //Si la posición es diferente de 1
                {
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        Puntero = Puntero.Siguiente;
                        if (Puntero.Siguiente == null) //Si se llega al final de la lista
                            break;
                    }

                    ListaNodo SiguientePuntero; //Puntero para ayudar
                    SiguientePuntero = Puntero.Siguiente; //Al nodo que apuntaba el puntero se ubicara el nuevo apuntador "SiguientePuntero"
                    Puntero.Siguiente = auxiliar; //El puntero señalara al nuevo nodo "auxiliar"
                    auxiliar.Siguiente = SiguientePuntero; //El nodo recien ingresado señalara al apuntador "SiguientePuntero"
                    //De manera resumida lo que hace es cortar la lista por un momento para ingresar el nuevo nodo
                    //Y luego uné la lista junto con el nuevo nodo añadido
                    

                }
                tamañoLista = tamañoLista + 1;
            }


        }
        //========================================================================================//

        //                    Método para eliminar un dato del frente
        public void EliminarAdelante()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacía, no se puede eliminar el elemento");
                Console.WriteLine("");
               
            }
            else
            {
                tamañoLista = tamañoLista - 1;
                primerNodo = primerNodo.Siguiente;
                
            }
        }
        //==========================================================================================//

        //                    Método para eliminar un dato al final
        public void EliminarAtras()
        {
            if(EstaVacia())
            {
                Console.WriteLine("La lista esta vacía, no se puede eliminar el dato!");
                Console.WriteLine("");
            }

            else
            {
                ListaNodo actual, punteroAnterior;
                punteroAnterior = primerNodo;
                actual = primerNodo;

                while(actual.Siguiente != null)
                {
                    punteroAnterior = actual;
                    actual = actual.Siguiente; //Avanza al siguiente nodo
                    
                }
                punteroAnterior.Siguiente = null;
                tamañoLista = tamañoLista - 1;
            }
        }
        //==========================================================================================//



        //                       Método para imprimir la lista
        public void ImprimirLista()
        {
            if(EstaVacia())
            {
                Console.WriteLine("\n La lista es vacía!");
                Console.WriteLine("");
                return;
            }

            Console.WriteLine("\n Mostrando lista, espere...");
            Console.WriteLine("");
            ListaNodo actual = primerNodo; //Puntero para recorrer la lista
            while(actual != null) // Si el puntero es diferente de null
            {
                Console.WriteLine("\n" + actual.Datos + "");
                actual = actual.Siguiente;
            }
            Console.WriteLine("\n");
            //Console.WriteLine("El tamaño de la lista es:" + tamañoLista);
        }
        //=========================================================================================//

    }
}
