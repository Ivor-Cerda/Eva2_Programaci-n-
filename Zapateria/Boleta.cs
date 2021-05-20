using System;
using System.Collections.Generic;
using System.Text;

namespace Zapateria
{
    class Boleta
    {
        public List<string> boleta = new List<string>();

        Cliente cliente = new Cliente();


        public void detalleBoleta()
        {
            Console.WriteLine("Nombre: "+cliente.Nombre);
            Console.WriteLine("Correo: "+cliente.Correo);
            Console.WriteLine("Teléfono: "+cliente.Telefono);
            Console.WriteLine("TOTAL: $"+Program.sumaTotal);

        }

    }
}
