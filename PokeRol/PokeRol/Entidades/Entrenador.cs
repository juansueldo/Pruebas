using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Genero { Femenino, Masculino, NoBinario}
    public class Entrenador
    {
        private string nombre;
        private string apellido;
        private short idEntrenador;
        private short edad;
        private Genero genero;
        private List<Pokemon> pokemons;
        private int cantidad;

        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public short IdEntrenador { get => idEntrenador; set => idEntrenador = value; }
        public short Edad { get => edad; set => edad = value; }
        public Genero Genero { get => genero; set => genero = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Entrenador(string nombre, string apellido, short idEntrenador, short edad, Genero genero, int cantidad)
            :this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.IdEntrenador = idEntrenador;
            this.Edad = edad;
            this.Genero = genero;
            this.cantidad = cantidad;
        }
        public Entrenador()
        {
            this.Pokemons = new List<Pokemon>();
        }
        public static Entrenador operator +(Entrenador e, Pokemon p)
        {
            if(e.pokemons.Count < e.Cantidad)
            {
                e.pokemons.Add(p);
            }
            else
            {
                throw new PokemonException("No puede llevar más pokemon, fue enviado a la pc de Bill");
            }
            return e;
        }
        public static Entrenador operator -(Entrenador e, Pokemon p)
        {
            foreach(Pokemon item in e.pokemons)
            {
                if(item == p)
                {
                    e.pokemons.Remove(p);
                }
                else
                {
                    throw new PokemonException("El pokemon que intenta eliminar no existe");
                }
            }
            return e;
        }
        public string EntrenadorDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Entrenador: {this.Nombre +' '+ this.Apellido}");
            sb.AppendLine($"ID: {this.idEntrenador}");
            sb.AppendLine($"Genero: {this.Genero}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Pokemon capturados\n");
            foreach (Pokemon item in this.Pokemons)
            {
                sb.AppendLine(item.PokemonDatos());
            }

            return sb.ToString();
        }
    }
}
