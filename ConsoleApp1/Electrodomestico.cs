using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Electrodomestico
    {
        public string Marca;
        public string Modelo;
        public bool Encendido;

        public Electrodomestico(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;

        }

        public void Encender()
        {
        Encendido = true;
            Console.WriteLine("El electrodomestico ha sido encendido");
        }
        public void Apagar()
        {
            Encendido = false;
            Console.WriteLine("El electrodomestico ha sido apagado");
        }
        public  string toString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}";
        }
    }   

}
