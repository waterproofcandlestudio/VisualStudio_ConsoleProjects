using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaObstaculos : MonoBehaviour
{
    class Pila
    {
        class Nodo
        {
            public int dato;
            public Nodo siguiente;
        }
        private Nodo cabeza;

        public Pila()
        {
            cabeza = null;
        }

        // Insertar los nums en una lista enlazada ordenada
        public void Insertar(int v)
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
            if (cabeza.dato > v)
            {
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            else
            {
                anterior = cabeza;
                // Buscamos el nodo d valor menor a v
                while (anterior.siguiente != null && anterior.siguiente.dato <= v)
                {
                    anterior = anterior.siguiente;
                }

                // Insertamos el nuevo nodo después del nodo anterior
                nuevoNodo.siguiente = anterior.siguiente;
                anterior.siguiente = nuevoNodo;
            }
        }
    }

    // Variable para que cada segundo se cree un nuevo obstáculo
    public float tiempoMax = 1;
    private float tiempoInicial = 0;
    public float altura;

    // Array para meter el numero total de obstáculos a ir rotando con el que esté seleccionado
    public ListaObstaculos[] obstaculo;
    public int obstaculoSeleccionado = 0;

    // Start is called before the first frame update
    void Start()
    {
        ListaObstaculos obstaculoNuevo = Instantiate(obstaculo);
        obstaculo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(gameObject, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoInicial > tiempoMax)
        {
            ListaObstaculos obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(gameObject, 100);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }
}
