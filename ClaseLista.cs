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
