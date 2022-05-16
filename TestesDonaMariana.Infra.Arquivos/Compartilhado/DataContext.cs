using TestesDonaMariana.Dominio.ModuloMateria;
/*using TestesDonaMariana.Dominio.ModuloTestes;
using TestesDonaMariana.Dominio.ModuloQuestoes;*/
using System;
using System.Collections.Generic;
using System.Linq;
using TestesDonaMariana.WinApp.Modulo_Materia;
using TestesDonaMariana.Dominio.ModuloQuestao;

namespace eAgenda.Infra.Arquivos
{
    [Serializable]
    public class DataContext //Container
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Materias = new List<Materia>();
            Questoes = new List<Questao>();
            
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Materia> Materias { get; set; }
        public List<Questao> Questoes { get; set; }
       
        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);
            if (ctx.Questoes.Any())
                this.Questoes.AddRange(ctx.Questoes);


        }
    }
}
