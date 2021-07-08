using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamientoTP2.Entidades
{
    class Playa
    {
        int id;
        int tamP;
        String nombre;

        public Playa(int id, String nombre, int tamP)
        {
            this.id = id;
            this.nombre = nombre;
            this.tamP = tamP; 
        }

        public Playa()
        {
        } 

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int TamP
        {
            get
            {
                return tamP;
            }
            set
            {
                tamP = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
    }
}
