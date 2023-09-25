using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Doblemente_Enlazada
{
    class ListaDoblementeEnlazada
    {
        int dato;
        Nodo siguiente = null;
        Nodo anterior = null;

        private Nodo cabeza;
        public Nodo()
        {
            cabeza = null;
        }

        public void Añadir(string v)
        {
            // Variables 
            Nodo nuevoNodo;
            Nodo nodoDeAcceso;

            // Caso General para añadir elementos a listas doblemente enlazadas
            // Paso 1
            nuevoNodo


            nodoDeAcceso = Nodo.siguiente;
            nodoDeAcceso.anterior(null) = Nodo.anterior;
            nodoDeAcceso.anterior = nuevoNodo;

        }

        public void Eliminar(string v2)
        {

        }
    }
}
