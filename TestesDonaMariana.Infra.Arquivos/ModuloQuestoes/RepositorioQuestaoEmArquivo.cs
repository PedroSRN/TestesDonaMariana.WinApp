using eAgenda.Infra.Arquivos;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TestesDonaMariana.Dominio.ModuloQuestao;
using TestesDonaMariana.Dominio.ModuloQuestoes;

namespace TestesDonaMariana.Infra.Arquivos.ModuloQuestoes
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questao>, IRepositorioQuestao
    {
        private object contextoDados;

        public RepositorioQuestaoEmArquivo(DataContext dataContext) :base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Numero);
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public void AdicionarAlternativas(Questao questaoSelecionada, List<Alternativas> alternativas)
        {
            foreach(var item in alternativas)
            {
                questaoSelecionada.AdicionarAlternativa(item);
            }
        }



        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }

    }
}
