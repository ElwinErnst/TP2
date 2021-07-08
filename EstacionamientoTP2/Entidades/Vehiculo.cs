using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;

namespace EstacionamientoTP2.Entidades
{
    class Vehiculo
    {
        int id;
        string modelo;
        string marca;
        string patente;

        public Vehiculo(int id, string modelo, string patente)
        {
            this.id = id;
            this.modelo = modelo;
            this.patente = patente;
        }
        
        public Vehiculo()
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
        public string Modelo
        {
            get
            {
                return Modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                patente = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        
    }
}

