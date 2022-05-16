using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMariana.Dominio.ModuloMateria;
using TestesDonaMariana.Infra.Arquivos.ModuloMateria;
using TestesDonaMariana.WinApp.Compartilhado;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private TabelaMateriaControl tabelaMateria;


        public ControladorMateria(IRepositorioMateria repositorioMateria)
        {
            this.repositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {
            var materia = repositorioMateria.SelecionarTodos();

            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm();
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }


        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Matéria primeiro",
                "Edição de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm();
            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Matéria primeiro",
                "Exclusão de Matérias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir uma matéria?",
                "Exclusão de Matérias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }


        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObtemListagem()
        {
            tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();
              
            return tabelaMateria;
        }



        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMateria.ObtemNumeroMateriaSelecionada();

            return repositorioMateria.SelecionarPorNumero(numero);
        }

        private void CarregarMaterias()
        {
            List<Materia> materia = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materia);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materia.Count} matéria(s)");
        }
    }
}

