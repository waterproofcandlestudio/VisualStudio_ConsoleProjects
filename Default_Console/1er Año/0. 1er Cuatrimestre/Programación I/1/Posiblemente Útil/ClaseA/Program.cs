using System;

namespace ClaseA
{
    class Program
    {
        // Ejercicio ESTRUCTURAS
        struct Contacto
        {
            public string name;
            public string lastName;
            public int phoneNumber;
        }
        static void Main(string[] args)
        {
            int inputMenu;
            bool salir = false;
            Contacto contactoAgenda;

            while(!salir)
            {
                MostrarMenu();
                inputMenu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Seleccione una opción");
                inputMenu = Convert.ToInt32(Console.ReadLine());

                switch (inputMenu)
                {
                    case 1:
                        //Almacenar contacto

                        break;
                    case 2:
                        VerContacto(contactoAgenda);

                        //ver contacto
                        break;
                    case 3;
                        //Borrar contacto
                        break;
                    case 4:
                        Console.WriteLine("Saliendo");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            
            }
        }

        static int menu()
        {
            Console.WriteLine("1 - Almacenar contacto");
            Console.WriteLine("2 - Ver contacto");
            Console.WriteLine("3 - Borrar contacto");
            Console.WriteLine("4 - Salir");
            return;
        }

        /// <summary>
        /// Método que genera un nuevo Contacto
        /// </summary>
        /// <returns>El contacto creado</returns>
        static void BorrarContacto(ref)
        {

        }

        static Contacto AlmacenarContacto()
        {
            Contacto nuevoContacto;

            Console.WriteLine("Introduzca un nobre para el nuevo contacto");
            contactoAgenda.name = Console.ReadLine();
            Console.WriteLine("Introduzca un apellido para el nuevo contacto");
            contactoAgenda.lastName = Console.ReadLine();
            Console.WriteLine("Introduzca un número de teléfono para el nuevo contacto");
            nuevoContacto.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            return nuevoContacto;
        }

        static void VerContacto(ContactoAMostrar)
        {
            Console.WriteLine("")
        }
    }
}
