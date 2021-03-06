using System;
using System.Windows.Forms;
using TestesDonaMariana.Dominio.ModuloQuestao;
using FluentValidation.Results;
using TestesDonaMariana.WinApp.Modulo_Materia;
using System.Collections.Generic;
using TestesDonaMariana.Dominio.ModuloQuestoes;
using System.Linq;

namespace TestesDonaMariana.WinApp.ModuloQuestoes
{
    public partial class TelaCadastroQuestaoForm : Form
    {
       
        private Questao questao;
        private List<Materia> materias;
        public TelaCadastroQuestaoForm(List<Materia> materias)
        {
            InitializeComponent();
            
            CarregarDisciplinas();
            this.materias = materias;


            
        }

        private void CarregarDisciplinas()
        {
            comboBox_Disciplina.Items.Clear();

            foreach(int  i in Enum.GetValues(typeof(DisciplinaEnum)))
            {
                comboBox_Disciplina.Items.Add((DisciplinaEnum)i);
            }
        }
       

        public Questao Questoes 
        {
            get 
            {
                return questao;
            }
            set
            {
                questao = value;
                txt_Enunciado.Text = questao.TituloPergunta;
                comboBox_Disciplina.SelectedItem = questao.Disciplina;
                comboBox_Materia.SelectedItem = questao.Materia;


            }
        }
        public Func<Questao, ValidationResult> GravarRegistro { get; internal set; }
      
        public List<Alternativas> AlternativasAdicionadas 
        {
            get
            {
                return list_Alternativas.Items.Cast<Alternativas>().ToList();
            } 
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            questao.TituloPergunta = txt_Enunciado.Text;
            
            questao.Disciplina = (DisciplinaEnum)comboBox_Disciplina.SelectedItem;
            questao.Materia = (Materia)comboBox_Materia.SelectedItem;

            
            

            var resultadoValidacao = GravarRegistro(questao);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }

        }
        private void comboBox_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManipularComboboxMateria();
        }

        private void ManipularComboboxMateria()
        {
            DisciplinaEnum disciplinaSelecionada = (DisciplinaEnum)comboBox_Disciplina.SelectedItem;
            
            List<Materia> materiasFiltradasPorDisciplinas = materias.FindAll(x => x.Disciplina == disciplinaSelecionada);
            comboBox_Materia.Items.Clear();
            foreach (var item in materiasFiltradasPorDisciplinas)comboBox_Materia.Items.Add(item);  

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            List<string> tituloAlterntiva = AlternativasAdicionadas.Select(x => x.TituloAlternativa).ToList();

            if (tituloAlterntiva.Count == 0 || tituloAlterntiva.Contains(txt_Alternativas.Text) == false)
            {
                Alternativas alternativas = new Alternativas();
                alternativas.TituloAlternativa = txt_Alternativas.Text;
                list_Alternativas.Items.Add(alternativas);
            }
        }
    }
}
