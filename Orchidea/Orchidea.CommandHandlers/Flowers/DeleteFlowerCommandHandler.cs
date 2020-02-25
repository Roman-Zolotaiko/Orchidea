using MediatR;
using Microsoft.EntityFrameworkCore;
using Orchidea.Commands.Flowers;
using Orchidea.Data.Context;
using System.Threading;
using System.Threading.Tasks;

namespace Orchidea.CommandHandlers.Flowers
{
    public class DeleteFlowerCommandHandler : BaseCommandHandler, IRequestHandler<DeleteFlowerCommand, bool>
    {
        public DeleteFlowerCommandHandler(OrchideaContext context) : base(context) { }

        public async Task<bool> Handle(DeleteFlowerCommand request, CancellationToken cancellationToken)
        {
            var flower = await _context.Flowers.FirstOrDefaultAsync(f => f.Id == request.Id, cancellationToken);

            _context.Remove(flower);

            var isSaved = await _context.SaveChangesAsync(cancellationToken) > 0;

            return isSaved;
        }
    }
}

