using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMariana.Dominio.Compartilhado;
using TestesDonaMariana.Dominio.ModuloQuestoes;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.Dominio.ModuloQuestao
{
    public class Questao: EntidadeBase<Questao>
    {
        private List<Alternativas> alternativas = new List<Alternativas>();
        public Questao()
        {

        }

        public Materia Materia { get; set; }
        public DisciplinaEnum Disciplina { get; set; }
        public string TituloPergunta{ get; set; }
        public List<Alternativas> Alternativas { get { return alternativas;} }

        public void AdicionarAlternativa(Alternativas alternativa)
        {
            if (Alternativas.Exists(x => x.Equals(alternativas)) == false)
                alternativas.Add(alternativa);
        }

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
