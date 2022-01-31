using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1Guía2
{
    class ListaNodo
    {
        private int datos; //Valor de dato que se agregara al arreglo

        public int Datos
        {
            get { return datos;}
            set { datos = value; }
        }

        private ListaNodo siguiente; //Variable que apunta al nodo siguiente

        public  ListaNodo Siguiente
        {
            get { return siguiente;}
            set { siguiente = value; }
        }

        public ListaNodo()
        {

        }


        /*
        public ListaNodo(int valorDatos) : this(valorDatos, null) { }

        public ListaNodo(int valorDatos, ListaNodo siguienteNodo)
        {
            datos = valorDatos;
            siguiente = siguienteNodo;
        }*/

    }
}
