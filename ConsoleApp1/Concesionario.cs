using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Concesionario
    {
        List<string> Coche = new List<string>(); //Cambio remember
        public int LimiteCoches;

        public Concesionario(int limiteCoche)
        {
            //Coche = new List<string>();
            LimiteCoches = limiteCoche;
        }

        public void aniadirCoche(string coche)
        {
            if (Coche.Count < LimiteCoches)
            {   
                Console.WriteLine("El coche se ha añadido");
                Coche.Add(coche);
            }
            else
            {
                Console.WriteLine("Se ha alcanzado el limite");
            }
        }
        public void mostrarCoches()
        {
            foreach(string carros in Coche)
            {
                Console.WriteLine(carros);
            }

        }
        public void vaciarCoches()
        {
            Coche.Clear();
            Console.WriteLine("Se han eliminado todos los coches");
        }
        public void eliminarCoche(string coche)
        {
            if (Coche.Contains(coche)){
                Coche.Remove(coche);
                Console.WriteLine($"Se ha eliminado el coche {coche} de la lista");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el coche");
            }
        }
    }
}
