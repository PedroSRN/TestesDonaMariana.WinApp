using eAgenda.WinApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.WinApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
            Grid_Materias.ConfigurarGridSomenteLeitura();
            Grid_Materias.ConfigurarGridZebrado();
            Grid_Materias.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NomeMateria", HeaderText = "Nome da Matéria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série"},

            };

            return colunas;
        }
        public int ObtemNumeroMateriaSelecionada()
        {
            return Grid_Materias.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
           Grid_Materias.Rows.Clear();

            foreach (Materia materia in materias)
            {
                Grid_Materias.Rows.Add(materia.Numero, materia.Disciplina, materia.NomeMateria, materia.Serie); //Adiciona os registros no grid
            }

            
        }
    }
}
