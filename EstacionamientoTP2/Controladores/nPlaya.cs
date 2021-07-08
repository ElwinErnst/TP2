using EstacionamientoTP2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuPrincipal;

namespace EstacionamientoTP2.Controladores
{
    class nPlaya
    {
        public static void Crear()
        {
            Console.Clear();

            Playa p = new Playa();
            Console.WriteLine("ingrese un id a la playa"); //definicion de los parametros de la playa.
            p.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un nombre a la playa");
            p.Nombre = Console.ReadLine();
            Vehiculo[,] matrizA = new Vehiculo[p.TamP, p.TamP];
            Boolean[,] matrizB = new bool[p.TamP, p.TamP];

            
            Vehiculo v = new Vehiculo();   // definicion de lugares (todos libres al crear la playa) esto es para evitar el que un objeto de tipo vehiculo sobreesctiba a otro
            for (int i = 0; i < p.TamP; i++)
            {
                for (int c = 0; c < p.TamP; i++)
                {
                    matrizB[i, c] = false;
                }
            }

        //}
        //public static void CargaMatriz()
        //{
            p.TamP = int.Parse(Console.ReadLine());

            for (int i = 0; i < p.TamP; i++)
            {
                for (int c = 0; c < p.TamP; i++)
                {
                    if (matrizB[i, c] == false)
                    {
                        matrizA[i, c] = v; //carga de vehiculos en ele estacionamiento / matriz
                        matrizB[i, c] = true;
                    }

                }
            }
        //}
        //public void quitarAuto()
        //{                                  esto es para quitar un auto de la matriz(playa de estacionamiento) aca faltaria agregar el cobro y el check out del registro
            int x;
            int y;
            Console.WriteLine("ingrese la fila del vehiculo a sacar de la playa");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la columna del vehiculo a sacar de la playa");
            y = int.Parse(Console.ReadLine());
            if (x < p.TamP && y < p.TamP)
            {
                matrizA[x, y] = null;
                matrizB[x, y] = false;
            }
        }

    }

    
}
