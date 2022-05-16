using eAgenda.Infra.Arquivos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMariana.Infra.Arquivos.ModuloMateria;
using TestesDonaMariana.Infra.Arquivos.ModuloQuestoes;
using TestesDonaMariana.WinApp.Compartilhado;
using TestesDonaMariana.WinApp.ModuloMateria;
using TestesDonaMariana.WinApp.ModuloQuestoes;
using TestesDonaMariana.WinApp.ModuloTeste;

namespace TestesDonaMariana.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;
       
        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            label_Rodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
            
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }
        public void AtualizarRodape(string mensagem)
        {
            label_Rodape.Text = mensagem;
        }
        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            ListagemTestesControl listagem = new ListagemTestesControl();
           
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btn_Inserir.Enabled = configuracao.InserirHabilitado;
            btn_Editar.Enabled = configuracao.EditarHabilitado;
            btn_Excluir.Enabled = configuracao.ExcluirHabilitado;
            btn_GerarPDF.Enabled = configuracao.GerarPdfHabilitado;
        }
        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btn_Inserir.ToolTipText = configuracao.TooltipInserir;
            btn_Editar.ToolTipText = configuracao.TooltipEditar;
            btn_Excluir.ToolTipText = configuracao.TooltipExcluir;
            btn_GerarPDF.Enabled = configuracao.GerarPdfHabilitado;
        }
        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;
            

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }
        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panel_Registros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panel_Registros.Controls.Add(listagemControl);
        }
        private void InicializarControladores()
        {
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioQuestao = new RepositorioQuestaoEmArquivo(contextoDados);
           



            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Matérias", new ControladorMateria(repositorioMateria));
            controladores.Add("Questões", new ControladorQuestao(repositorioQuestao, repositorioMateria));    
           
          
        }

       
    }
}
