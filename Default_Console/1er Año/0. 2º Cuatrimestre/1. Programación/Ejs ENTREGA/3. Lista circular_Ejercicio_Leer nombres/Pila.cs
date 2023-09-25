using System;
// Miguel Rodríguez Gallego
namespace Lista_circular_Ejercicio_Leer_nombres
{
    class Pila
    {
        class Nodo
        {
            public string dato;
            public Nodo siguiente;
        }
        private Nodo cabeza;

        public Pila()
        {
            cabeza = null;
        }

        public void Insertar(string v)
        {
            // Variables auxiliares
            Nodo nuevoNodo;
            Nodo anterior;

            // Creamos nuestro nuevo nodo
            nuevoNodo = new Nodo();
            // Meto el dato que me pasan en una variable
            nuevoNodo.dato = v;
            anterior = null;

            // Si la lista está vacía o queremos insertar en la cabecera. (Suponemos q la función "ListaVacía()" ya está implementada).
            if (ListaVacia() || cabeza.dato.CompareTo(v) == +1)
            {
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            else
            {
                anterior = cabeza;
                // Buscamos el nodo d valor menor a v
                while (anterior.siguiente != null && anterior.siguiente.dato.CompareTo(v) <= 0)
                {
                    anterior = anterior.siguiente;
                }

                // Añado el nuevo nodo
                nuevoNodo.siguiente = anterior.siguiente;
                anterior.siguiente = nuevoNodo;
            }
        }

        // Creo una lista vacía
        public bool ListaVacia()
        {
            if (cabeza == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CerrarLista()
        {
            // Creo el nodo "indice"
            Nodo indice = cabeza;
            // Abro un "if" para mostrar mediante el método "ListaVacia" un msg d lista vacía si no hay datos/se borraron todos
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Creo un else para mostrar los datos si los hay
            else
            {
                // Creo la variable i para hacer de contador al lado de los nºs que muestre por pantalla a su izquierda

                Console.WriteLine("Cabeza: " + cabeza.dato);

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != null)
                {
                    indice = indice.siguiente;
                    Console.WriteLine("Dato: " + " - " + indice.dato);
                }
            }
            indice.siguiente = cabeza;
        }
        public void MostrarLista()
        {
            // Creo el nodo "indice"
            Nodo indice = cabeza;
            // Abro un "if" para mostrar mediante el método "ListaVacia" un msg d lista vacía si no hay datos/se borraron todos
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacía");
            }
            // Creo un else para mostrar los datos si los hay
            else
            {
                // Creo la variable i para hacer de contador al lado de los nºs que muestre por pantalla a su izquierda
                int i = 1;
                Console.WriteLine("Dato: " + i + " - " + indice.dato);

                // Vamos avanzando por la lista hasta el último elemento
                while (indice.siguiente != cabeza)
                {
                    i++;
                    indice = indice.siguiente;
                    Console.WriteLine("Dato: " + i + " - " + indice.dato);
                }
            }
        }
    }
}
