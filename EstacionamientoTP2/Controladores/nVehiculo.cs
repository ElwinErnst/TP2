using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamientoTP2.Entidades;
using MenuPrincipal;

namespace EstacionamientoTP2.Controladores
{
    class nVehiculo
    {
        public static void Crear()
        { 
            Console.Clear();
            Vehiculo v = new Vehiculo();

            Console.WriteLine("Ingrese el ID: ");
            v.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Modelo del vehiculo: ");
            v.Modelo = Console.ReadLine();

            Console.WriteLine("Ingrese la patente: ");
            v.Patente = Console.ReadLine();

            Program.vehiculo.Add(v);
        }

        public static void Listar()
        {
            Console.Clear();
            foreach (Vehiculo v in Program.vehiculo)
            {
                Console.WriteLine("{0} - {1}, {2}", Program.vehiculo.IndexOf(v) + 1, v.Modelo, v.Patente);
            }
        }

        public static int Seleccionar()
        {
            int s;
            Listar();
            Console.WriteLine("Seleccione un vehiculo: ");
            s = int.Parse(Console.ReadLine());

            return s - 1;
        }

        public static void Modificar()
        {
            int x = 0;
            Vehiculo v = Program.vehiculo.ElementAt(Seleccionar());
            Console.WriteLine("Seleccione que desea modificar: ");
            Console.WriteLine("1 - Modelo");
            Console.WriteLine("2 - Patente");
            x = int.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine("Escriba el nuevo modelo: ");
                    v.Modelo = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Escriba la nueva patente: ");
                    v.Patente = Console.ReadLine();
                    break;
            }

        }

        public static void Menu()
        {
            Console.Clear();
            string[] opciones = new string[5] { "Crear", "Listar", "Eliminar", "Modificar", "Salir" };
            string titulo = "PLAYA ESTACIONAMIENTO";

            Herramientas.DibujoMenu(titulo, opciones);
            int op = Herramientas.LeerEntero(1, 6);

            switch (op)
            {
                case 1:
                    Crear(); Menu();
                    break;
                case 2:
                    Listar(); Console.ReadKey(true); Menu();
                    break;
                case 3:
                    Program.vehiculo.RemoveAt(Seleccionar()); Menu();
                    break;
                case 4:
                    Modificar(); Menu();
                    break;
                case 5:
                    break;
            }
        }
    }
}
