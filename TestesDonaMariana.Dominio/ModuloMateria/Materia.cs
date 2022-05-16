using TestesDonaMariana.Dominio.Compartilhado;
using TestesDonaMariana.Dominio.ModuloMateria;

namespace TestesDonaMariana.WinApp.Modulo_Materia
{
    public class Materia : EntidadeBase<Materia>
    {
        public Materia()
        {
            
        }

        public string NomeMateria { get; set; }
        public DisciplinaEnum Disciplina { get; set; }
        public SerieEnum Serie { get; set; }    
    

        public override void Atualizar(Materia registro)
        {
           this.NomeMateria = registro.NomeMateria;
        }


        public override string ToString()
        {
            return $"Número: {Numero}, Nome da Matéria: {NomeMateria}, Diciplina: {Disciplina}, Serie: {Serie}";
        }

    }
}
