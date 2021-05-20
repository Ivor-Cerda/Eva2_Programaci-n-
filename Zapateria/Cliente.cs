using System;
using System.Collections.Generic;
using System.Text;

namespace Zapateria
{
    class Cliente
    {
        private static String nombre;
        private static String correo;
        private static int telefono;

        public Cliente()
        {
        }

        public Cliente(string nombre, string corre, int telefono)
        {
            this.Nombre = nombre;
            this.Correo = corre;
            this.Telefono = telefono;


        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
