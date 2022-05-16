using eAgenda.Infra.Arquivos;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TestesDonaMariana.Dominio.ModuloMateria;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
        private object contextoDados;

        public RepositorioMateriaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Numero);
        }

        public override List<Materia> ObterRegistros()
        {
          return dataContext.Materias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}
