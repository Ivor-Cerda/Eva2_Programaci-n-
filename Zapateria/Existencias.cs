using System;
using System.Collections.Generic;
using System.Text;

namespace Zapateria
{
    class Existencias
    {
        public List<Existencias> producto = new List<Existencias>();//esto declara una lista con todos los productos
        

        private int id;
        private string nombre;
        private int precio;


        public Existencias() //ESTO RELLENA LA LISTA <PRODUCTO> 
        {
            producto.Add(new Existencias(1, "Alpargata",  10));
            producto.Add(new Existencias(2, "Botas", 20));
            producto.Add(new Existencias(3, "Chancla", 30));
            producto.Add(new Existencias(4, "Botas de agua", 40));
            producto.Add(new Existencias(5, "Mocasínes", 50));
            producto.Add(new Existencias(6, "Náutico", 60));
            producto.Add(new Existencias(7, "Pantufla", 70));
            producto.Add(new Existencias(8, "Sandalia", 80));
            producto.Add(new Existencias(9, "Zapato formal", 90));
            producto.Add(new Existencias(10, "Zapato Taco", 100));
            producto.Add(new Existencias(11, "Albarcas", 110));
            producto.Add(new Existencias(12, "Ankle strap", 120));
            producto.Add(new Existencias(13, "Bailarinas", 130));
            producto.Add(new Existencias(14, "Bluchers", 140));
            producto.Add(new Existencias(15, "Botines", 150));
            producto.Add(new Existencias(16, "Creepers", 160));
            producto.Add(new Existencias(17, "Cuñas", 170));
            producto.Add(new Existencias(18, "Tennis", 180));
            producto.Add(new Existencias(19, "Running", 190));
            producto.Add(new Existencias(20, "Lonas", 200));
            producto.Add(new Existencias(21, "Merceditas", 210));
            producto.Add(new Existencias(22, "Monk", 220));
            producto.Add(new Existencias(23, "Mules", 230));
            producto.Add(new Existencias(24, "Oxford", 240));
            producto.Add(new Existencias(25, "Peep toes", 250));
            producto.Add(new Existencias(26, "Salones", 260));
            producto.Add(new Existencias(27, "Slip on", 270));
            producto.Add(new Existencias(28, "Slingback", 280));
            producto.Add(new Existencias(29, "Zuecos", 290));
            producto.Add(new Existencias(30, "T-strap", 300));





        }

        public Existencias(int id, string nombre, int precio)//CONSTRUCTOR CON PARAMETROS
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }




        //getter y setter de la <lista TIPO>

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
    }

    
    

    
}
