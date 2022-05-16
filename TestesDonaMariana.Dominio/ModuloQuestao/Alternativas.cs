using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMariana.Dominio.ModuloQuestoes
{
    [Serializable]
    public class Alternativas
    {
        public string TituloAlternativa { get; set; }

        public override string ToString()
        {
            return TituloAlternativa;
        }
    }
}
