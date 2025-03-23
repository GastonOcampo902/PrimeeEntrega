using System;

namespace PrimeeEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           
        }
    }
    //Primer clase 
    public class Guitarra
    {
       //Atributos
        public string Marca;
        public string Modelo;
        public int Precio;
        public int AñoFabicacion;

        //Metodos
        public void Sonido () 
            {
                Console.WriteLine("La guitarra esta sonando.");
            }
        public void Costo()
        {
            Console.WriteLine("La guitarra es barata.");
        }
     }

    //Segunda clase
    public class Perro
    {
        //Atributos
        public string Color;
        public string Nombre;
        public string Años;

        //Metodos

        public void Comer()
        {
            Console.WriteLine("El perro esta comiendo.");
        }
        public void Jugar()
        {
            Console.WriteLine("El perro esta jugando.");
        }
    }
}
