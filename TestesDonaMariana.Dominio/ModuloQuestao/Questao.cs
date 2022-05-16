using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMariana.Dominio.Compartilhado;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.Dominio.ModuloQuestao
{
    public class Questao: EntidadeBase<Questao>
    {
        public Questao()
        {

        }

        public Materia Materia { get; set; }
        public DisciplinaEnum Disciplina { get; set; }
        public string TituloPergunta{ get; set; }
      
        public override void Atualizar(Questao registro)
        {
            this.TituloPergunta = registro.TituloPergunta;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Disciplina: {Disciplina}, Materia: {Materia}, Enunciado: {TituloPergunta}";
        }
    }
}
