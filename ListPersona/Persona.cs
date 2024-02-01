using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPersona
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public Persona(string nome, int eta)
        {
            Nome = nome;
            Eta = eta;
        }
    }
}
