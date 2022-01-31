using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1Guía2
{
    class ClaseLista
    {

        public ListaNodo primerNodo;
        public ListaNodo ultimoNodo;

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
            }
        }
        //============================================================//

        //Método para ingresar un valor al principio, de tal manera que la cabecerá cambie
        public void InsertalInicio(int digito)
        {
            ListaNodo auxiliar = new ListaNodo();
            auxiliar.Datos = digito;
            auxiliar.Siguiente = null;

            if(EstaVacia())
            {
                primerNodo = ultimoNodo = auxiliar;
            }
            else
            {
                ListaNodo puntero; //Usado para recorrer la lista
                puntero = primerNodo;
                primerNodo = auxiliar;
                auxiliar.Siguiente = puntero; //Lo que hace es modificar la cabecera de tal manera que el auxiliar se poné como
                                              //primer nodo: valor siguiente del auxiliar será el puntero
            }
        }
        //================================================================//

        //Método para insertar en una posición en concreto de la lista
        public void InsertarPosición(int digito, int posicion)
        {
            ListaNodo auxiliar = new ListaNodo();
            auxiliar.Datos = digito;
            auxiliar.Siguiente = null;

        }


        //Método para eliminar un dato del frente
        public void EliminarAdelante()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La lista esta vacía, no se puede eliminar el elemento");
            }
            else
            {
                primerNodo = primerNodo.Siguiente;
            }
        }
        //==========================================================================================//

        //Método para eliminar un dato al final
        public void EliminarAtras()
        {
            if(EstaVacia())
            {
                Console.WriteLine("La lista esta vacía, no se puede eliminar el dato");
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
            }
        }
        //==========================================================================================//



        //Método para imprimir la lista
        public void ImprimirLista()
        {
            if(EstaVacia())
            {
                Console.WriteLine("\n La lista es vacía!");
                return;
            }

            Console.WriteLine("\n Mostrando lista, espere...");
            ListaNodo actual = primerNodo; //Puntero para recorrer la lista
            while(actual != null) // Si el puntero es diferente de null
            {
                Console.WriteLine("\n" + actual.Datos + "");
                actual = actual.Siguiente;
            }
            Console.WriteLine("\n");

        }


    }
}
