using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipo {Agua, Fuego, Planta, Normal, Bicho, Psiquico, Electrico, Fantasma, Roca, Tierra, Hielo, Dragon,
    Acero ,Lucha , Volador,Veneno, Siniestro, Hada,Ninguno}
    public class Pokemon
    {
        private short idPokemon;
        private string nombre;
        private Tipo tipo;
        private Tipo subTipo;

        public short IdPokemon { get => idPokemon; set => idPokemon = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Tipo Tipo { get => tipo; set => tipo = value; }
        public Tipo SubTipo { get => subTipo; set => subTipo = value;}
        public Pokemon(Tipo subTipo, Tipo tipo, string nombre, short idPokemon)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.IdPokemon = idPokemon;
            this.SubTipo = subTipo;
        }
        public static bool operator ==(Pokemon p1, Pokemon p2)
        {
            bool retorno = false;
            if(p1.idPokemon == p2.idPokemon)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Pokemon p1, Pokemon p2)
        {
            return !(p1 == p2);
        }
        public string PokemonDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            if(this.SubTipo is Tipo.Ninguno)
            {
                sb.AppendLine($"Tipo: {this.Tipo}");
            }
            else
            {
                sb.AppendLine($"Tipo: {this.Tipo} {this.SubTipo}");     
            }
            sb.AppendLine($"ID: {this.IdPokemon}");

            return sb.ToString();
        }
    }
}
