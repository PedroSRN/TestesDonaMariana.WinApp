using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMariana.Dominio.ModuloMateria;
using TestesDonaMariana.Dominio.ModuloQuestao;
using TestesDonaMariana.Dominio.ModuloQuestoes;
using TestesDonaMariana.Infra.Arquivos.ModuloQuestoes;
using TestesDonaMariana.WinApp.Compartilhado;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.WinApp.ModuloQuestoes
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioMateria repositorioMateria;

        private TabelaQuestaoControl tabelaQuestao;
      //  private List<Materia> materias;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {
            var materias = repositorioMateria.SelecionarTodos();
            //var questao = repositorioQuestao.SelecionarTodos();

            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(materias);
            tela.Questoes = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            Questao questaoSelecionada = ObtemQuestaoSelecionada();

               List<Alternativas> alternativas = tela.AlternativasAdicionadas;

               repositorioQuestao.AdicionarAlternativas(questaoSelecionada, alternativas);
               
            
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Editar()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(materias);

            tela.Questoes = questaoSelecionada;

            tela.GravarRegistro = repositorioQuestao.Editar;

            DialogResult resultado = tela .ShowDialog();

            if(resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a questão?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }
        }

        //public virtual void AdicionarAlternativas()
        //{
        //    Questao questaoSelecionada = ObtemQuestaoSelecionada();

           
          
        //    {
        //        List<Alternativas> alternativas = tela.AlternativasAdicionadas;

        //        repositorioQuestao.AdicionarAlternativas(questaoSelecionada, alternativas);
        //        CarregarQuestoes();
        //    }
        //}
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
           tabelaQuestao = new TabelaQuestaoControl();
            
            CarregarQuestoes();

            return tabelaQuestao;
        }

        private Questao ObtemQuestaoSelecionada() 
        {
            var numero = tabelaQuestao.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorNumero((int)numero);
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {questoes.Count} questão(ôes)");
        }
    }
}
