using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Hola a todos. Mi nombre es Sury");

            Console.WriteLine("Podrias decirme como te llamas? : ");
            nombre = Console.ReadLine();

            Console.WriteLine("Es un gusto tenerte por aqui " + nombre);
        }
    }

}
