using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Combustible
    {
        protected decimal Precio { set; get; }
        protected bool Disponibilidad { set; get; }



        public Combustible(decimal precio, string disponibilidad) 
        {
            Precio = precio;
            if (disponibilidad.ToUpper() == "SI")
            {
                Disponibilidad = true;
            }
            else if(disponibilidad.ToUpper() == "NO"){
                Disponibilidad = false;
                return;
            }
            else {
                Console.WriteLine("Digite un valor valido");
            }
        }
        public decimal obtenerPrecio()
        {
            return Precio; 
        }
        public bool obtenerDisponibilidad()
        {
            return Disponibilidad;
        }
        public void SetPrecio(decimal precio)
        {
            Precio = precio;
        }
        public class GasolinaRegular : Combustible
        {
            public GasolinaRegular(decimal precio, string disponibilidad) : base(precio, disponibilidad)
            {
                    if (disponibilidad.ToUpper() == "SI")
                    {
                        Disponibilidad = true;
                        Console.WriteLine("Hay Gasolina Regular Disponible");
                    }
                        else if (disponibilidad.ToUpper() == "NO")
                        {
                            Disponibilidad = false;
                            Console.WriteLine(" No hay Gasolina Regular Disponible");
                                return;                    
                        }
                        else
                        {
                        Console.WriteLine("Opcion invalida");
                    
                        }
                Precio = precio;
            }
            public decimal calcularMonto(decimal galones)
            {
                return galones * Precio; //return galones * obtenerPrecio;
 

            }
        }
        public class GasolinaPremium : Combustible
        {
            public GasolinaPremium(decimal precio, string disponibilidad) : base (precio, disponibilidad)
            {
                if (disponibilidad.ToUpper() == "SI")
                {
                    Disponibilidad = true;
                    Console.WriteLine("Hay Gasolina Premium Disponible");
                }
                else if (disponibilidad.ToUpper() == "NO")
                {
                    Disponibilidad = false;
                    Console.WriteLine(" No hay Gasolina Premium Disponible");
                    return;
                }
                else
                {
                    Console.WriteLine("Opcion invalida");

                }
                Precio = precio;
            }
            public decimal calcularMonto(decimal galones)
            {
                return galones * Precio; //galones * obtenerPrecio();

            }
        }
        public class Diesel : Combustible
        {
            public Diesel(decimal precio, string disponibilidad) : base(precio, disponibilidad)
            {
                if (disponibilidad.ToUpper() == "SI")
                {
                    Disponibilidad = true;
                    Console.WriteLine("Hay Diesel Disponible");
                }
                else if (disponibilidad.ToUpper() == "NO")
                {
                    Disponibilidad = false;
                    Console.WriteLine(" No hay Diesel Disponible");
                    return;
                }
                else
                {
                    Console.WriteLine("Opcion invalida");

                }


            }
            public decimal calcularMonto(decimal galones)
            {
                return galones * Precio; //galones * obtenerPrecio();

            }
        }
        }
    }


