
using System.Collections.Generic;
using TestesDonaMariana.Dominio.Compartilhado;
using TestesDonaMariana.Dominio.ModuloQuestoes;

namespace TestesDonaMariana.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorio<Questao>
    {
        void AdicionarAlternativas(Questao questaoSelecionada,List<Alternativas> alternativas);
    }
}
