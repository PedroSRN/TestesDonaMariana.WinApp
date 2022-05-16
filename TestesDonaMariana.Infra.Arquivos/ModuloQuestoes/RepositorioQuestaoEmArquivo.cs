using eAgenda.Infra.Arquivos;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TestesDonaMariana.Dominio.ModuloQuestao;

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

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }

    }
}
