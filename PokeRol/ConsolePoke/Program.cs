using System;
using Entidades;

namespace ConsolePoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador e = new Entrenador("Ash", "Ketchup", 01, 10, Genero.Masculino,6);
            /*e.Nombre = "Ash";
            e.Apellido = "Ketchup";
            e.IdEntrenador = 01;
            e.Edad = 10;
            e.Genero = Genero.Masculino;
            e.Cantidad = 6;*/
            Pokemon p1 = new Pokemon(Tipo.Electrico, "Pikachu", 25);
            Pokemon p2 = new Pokemon(Tipo.Bicho, "Caterpie", 15);
            Pokemon p3 = new Pokemon(Tipo.Psiquico, "Abra",22);
            Pokemon p4 = new Pokemon(Tipo.Normal, "Pidgey", 12);
            Pokemon p5 = new Pokemon(Tipo.Agua, "Squartle", 4);
            Pokemon p6 = new Pokemon(Tipo.Planta, "Bulbasaur",1);
            Pokemon p7 = new Pokemon(Tipo.Fuego, "Charmander",6);

            try
            {
                e += p1;
                Console.WriteLine($"{p1.Nombre} capturado");
            }
            catch(PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p2;
                Console.WriteLine($"{p2.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p3;
                Console.WriteLine($"{p3.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p4;
                Console.WriteLine($"{p4.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p5;
                Console.WriteLine($"{p5.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p6;
                Console.WriteLine($"{p6.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                e += p7;
                Console.WriteLine($"{p7.Nombre} capturado");
            }
            catch (PokemonException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(e.EntrenadorDatos());
            Console.ReadKey();
        }
    }
}
