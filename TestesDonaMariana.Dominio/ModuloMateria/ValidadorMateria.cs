using FluentValidation;
using TestesDonaMariana.WinApp.Modulo_Materia;

namespace TestesDonaMariana.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {


            RuleFor(x => x.NomeMateria) // validação do nome da matéria
                .NotEmpty()
                .NotNull();
               // .NotEqual(x => x.NomeMateria);




        }
    }
}
