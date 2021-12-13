using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PokemonException : Exception
    {
        public PokemonException(string message) : base(message) { }

        public PokemonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
