using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMariana.WinApp.Compartilhado;

namespace TestesDonaMariana.WinApp.ModuloQuestoes
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Questões";

        public override string TooltipInserir => "Inserir uma nova questão";

        public override string TooltipEditar => "Editar uma questão existente";

        public override string TooltipExcluir => "Excluir uma questão existente";
    }
}
