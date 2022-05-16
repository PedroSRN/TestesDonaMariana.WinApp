using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMariana.Dominio.ModuloQuestao;

namespace TestesDonaMariana.WinApp.ModuloQuestoes
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            Grid_Questao.ConfigurarGridSomenteLeitura();
            Grid_Questao.ConfigurarGridZebrado();
            Grid_Questao.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NomeMateria", HeaderText = "Nome da Matéria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TituloPergunta", HeaderText = "Titulo da Pergunta"},

            };

            return colunas;
        }


        public object ObtemNumeroQuestaoSelecionada()
        {
            return Grid_Questao.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            Grid_Questao.Rows.Clear();

            foreach (Questao questao in questoes)
            {
                Grid_Questao.Rows.Add(questao.Numero, questao.Disciplina,questao.Materia.NomeMateria, questao.TituloPergunta); 
            }
        }
    }
}
