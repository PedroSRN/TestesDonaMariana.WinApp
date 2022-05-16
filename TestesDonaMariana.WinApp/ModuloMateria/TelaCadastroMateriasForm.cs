using FluentValidation.Results;
using System;
using System.Windows.Forms;
using TestesDonaMariana.Dominio.ModuloMateria;
using TestesDonaMariana.WinApp.Compartilhado;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriasForm : Form
    {

        private Materia materia;

        public TelaCadastroMateriasForm()
        {
            InitializeComponent();
            CarregarDisciplinas();
            CarregarSeries();
        }

        private void CarregarDisciplinas()
        {
            var disciplinas = Enum.GetValues(typeof(DisciplinaEnum));

            foreach (var item in disciplinas)
            {
                comboBox_Disciplina.Items.Add(item);
            }
        }
        private void CarregarSeries()
        {
            var series = Enum.GetValues(typeof(SerieEnum));

            foreach (var item in series)
            {
                comboBox_Serie.Items.Add(item);
            }
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; internal set; }

        public Materia Materia 
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
                txt_NomeMateria.Text = materia.NomeMateria;
                comboBox_Disciplina.SelectedItem = materia.Disciplina;
                comboBox_Serie.SelectedItem = materia.Serie;

            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
         materia.NomeMateria = txt_NomeMateria.Text;
         materia.Disciplina = (DisciplinaEnum)comboBox_Disciplina.SelectedItem;
         materia.Serie = (SerieEnum)comboBox_Serie.SelectedItem;



            var resultadoValidacao = GravarRegistro(materia);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

       
    }
}
