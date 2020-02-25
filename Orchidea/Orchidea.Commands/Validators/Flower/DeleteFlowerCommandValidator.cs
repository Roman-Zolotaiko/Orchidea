using FluentValidation;
using Orchidea.Commands.Flowers;
using Orchidea.Data.Context;
using System.Linq;

namespace Orchidea.Commands.Validators.Flower
{
    public class DeleteFlowerCommandValidator : AbstractValidator<DeleteFlowerCommand>
    {
        public DeleteFlowerCommandValidator(OrchideaContext context)
        {
            RuleFor(x => x.Id)
             .Must(id => context.Flowers.Any(f => f.Id == id) && id != default)
             .WithMessage("Element is not exist.")
             .NotEmpty()
             .WithMessage("Id is null or empty.");
        }
    }
}
