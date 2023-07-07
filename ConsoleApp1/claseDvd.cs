using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class claseDvd
    {
        private string Marca { get; set; }
        private string Modelo { get; set;}

        public bool Reproduciendo;


        public claseDvd(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Reproducir()
        {
            Console.WriteLine("Se esta reproduciendo el disco");
            Reproduciendo = true;
        }
        public void Detener()
        {
            Console.WriteLine("Se ha detenido el disco");
            Reproduciendo = false;
        }
    }
    






}
