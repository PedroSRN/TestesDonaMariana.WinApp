using FluentValidation;


namespace TestesDonaMariana.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {

        public ValidadorQuestao()
        {
            RuleFor(x => x.TituloPergunta)
                .NotEmpty()
                .NotNull()
                .NotEqual(x => x.TituloPergunta);
                
               




        }
    }
}
