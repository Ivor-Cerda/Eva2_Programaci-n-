using System;
using System.Collections.Generic;
using System.Linq;


namespace Zapateria
{
    class Program
    {

        private static int res = 1;

        static Existencias existencia = new Existencias();
        static Carrito carrito = new Carrito();
        static Boleta boleta = new Boleta();
        static Cliente cliente = new Cliente();
        public static int sumaTotal = 0;




        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al carrito de compras de la zapatería don Samuel \n" +
                "Elige una opción para continuar: ");
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Añadir producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Ver carrito");
                Console.WriteLine("4. Pagar");
                Console.WriteLine("5. Salir");
                Console.WriteLine("------------------------------------------");
                res = Int32.Parse(Console.ReadLine());


                switch (res)
                {
                    case 1://AÑADIR PRODUCTO
                        Console.Clear();
                        int num = 1;
                        string cicloAgregar = "";
                        string respuesta;


                        do
                        {

                            Console.Clear();
                            //FOREACH QUE RECORRE LA LISTA <TIPO> DE LA CLASE "EXISTENCIAS"!!!
                            foreach (var item in existencia.producto)
                            {
                                //esta linea se encarga de escribir todos los items contenidos dentro de la lista tipo /clase Existencias
                                Console.WriteLine(num + ". " + item.Nombre + " $" + item.Precio); //SOLO LLAMA AL NOMBRE Y AL PRECIO DE LA LISTA <producto> / de la clase existencias
                                num++;


                            }
                            Console.WriteLine("\nSeleccione un producto ingresando el NUMERO de este");
                            int opcion = Int32.Parse(Console.ReadLine());
                            if (opcion >= 1 && opcion <= existencia.producto.Count)
                            {
                                Console.Clear();
                                //ESTO COPIA AL PRODUCTO DESDE LA LISTA <producto> hacia la lista <carrito>                          
                                carrito.carrito.Add(existencia.producto[opcion - 1]);




                                Console.WriteLine("*********************************");
                                Console.WriteLine("PRODUCTO AGREGADO EXITOSAMENTE!");
                                Console.WriteLine("*********************************");


                                do
                                {
                                    Console.WriteLine("Desea agregar mas productos [si] [no] \n " + "(escriba si o no para continuar)");
                                    respuesta = Console.ReadLine().ToLower();
                                } while (!(respuesta.Equals("si") || respuesta.Equals("no")));
                                cicloAgregar = respuesta;
                                num = 1;

                            }
                        } while (cicloAgregar.Equals("si"));
                        Console.Clear();


                        res = -1; //esto hace que pueda volver al menu luego de ejecutar una opcion del MENU

                        break;

                    case 2://ELIMINAR PRODUCTO
                        Console.Clear();

                        foreach (var producto in carrito.carrito)
                        {
                            Console.WriteLine("ID: " + producto.Id + " " + producto.Nombre + " $" + producto.Precio);

                        }
                        Console.WriteLine("\nDigite la ID del elemento que desea eliminar");
                        int a = Int32.Parse(Console.ReadLine());
                        if (carrito.carrito.Count != 0)//si carrito no esta vacio prosigue a...
                        {
                            foreach (var item in carrito.carrito)// recorre la lista <carrito>
                            {
                                if (item.Id == a)
                                {
                                    carrito.carrito.Remove(item);
                                    Console.WriteLine("PRODUCTO ELIMINADO!!");
                                    break;
                                }
                                
                            }

                        }
                        Console.Clear();

                        res = -1;

                        break;

                    case 3://VER CARRITO
                        Console.Clear();
                        var query = from producto in carrito.carrito orderby producto.Precio ascending select new { producto.Id, producto.Nombre, producto.Precio };//LINQ que ordena de menor a mayor deacuerdo al precio
                        foreach (var x in query)
                        {
                            Console.WriteLine(x);
                        }
                        //ESTE FOREACH MUESTRA LO QUE ESTA CONTENIDO DENTRO DE LA LISTA <carrito>
                        //foreach (var producto in carrito.carrito)
                        //{
                        //    Console.WriteLine("ID: " + producto.Id + " " + producto.Nombre + " $" + producto.Precio);

                        //}


                        res = -1;
                        break;

                    case 4://PAGAR                     
                        Console.Clear();
                        if(carrito.carrito.Count !=0)
                        {
                            string resp2;
                            //ESTE FOREACH MUESTRA LO QUE ESTA CONTENIDO DENTRO DE LA LISTA <carrito>
                            foreach (var producto in carrito.carrito)
                            {
                                Console.WriteLine("ID: " + producto.Id + " " + producto.Nombre + " $" + producto.Precio);
                                sumaTotal = sumaTotal + producto.Precio;

                            }
                            Console.WriteLine("\nTOTAL A PAGAR: $" + sumaTotal);
                            do {
                                Console.WriteLine("Desea continuar con el pago [si] [no]?");
                                resp2 = Console.ReadLine().ToLower();
                            } while (!(resp2.Equals("si") || resp2.Equals("no")));
                            if (resp2.Equals("si"))
                            {
                                Console.WriteLine("Ingrese su nombre");
                                cliente.Nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese su correo");
                                cliente.Correo = Console.ReadLine();
                                Console.WriteLine("Ingrese su Teléfono ");
                                cliente.Telefono = Int32.Parse(Console.ReadLine());
                                Console.Clear();
                                boleta.detalleBoleta();//muestra detalle boleta
                            }
                            else
                            {
                                res = -1;
                            }
                        }
                        res = -1;
                        
                                          

                        

                        break;

                    case 5://SALIR  
                        
                        Environment.Exit(0); //cierra la aplicacion
                        break;


                }
            } while (res < 1 || res > 5);





        }
    }
}
