using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListaSprites : MonoBehaviour
{
    // Variable para que cada segundo se cree un nuevo obstáculo
    public float tiempoMax = 1;
    private float tiempoInicial = 0;
    public float altura;

    // Array para meter el numero total de obstáculos a ir rotando con el que esté seleccionado
    public ListaSprites[] obstaculo;
    public int obstaculoSeleccionado = 0;

    // Start is called before the first frame update
    void Start()
    {
        ListaSprites obstaculoNuevo = Instantiate(obstaculo);
        obstaculo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(gameObject, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoInicial > tiempoMax)
        {
            ListaSprites obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(gameObject, 100);
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }

    static void Main(string[] args)
    {
        // Variable para el contador de términos
        int contador = 0;

        // Creo una nueva ranura de memoria para la pila nombres
        Pila nombres = new Pila();
        string nombre = " ";

        // Hago un bucle en el que mientras que el usuario no introduzca fin se ejecute el programa
        while (nombre != "FIN")
        {
            contador++;
            // Bucle if para insertar los nombres en la pila
            if (nombre != "FIN")
            {
                nombres.Insertar(nombre);
            }
        }
        // Expongo el Nº total de números
        Console.WriteLine(contador - 1);
        // Expongo los datos con los métodos ligados a la clase pila
        nombres.CerrarLista();
        nombres.MostrarLista();
    }


}