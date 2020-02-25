using MediatR;
using System;

namespace Orchidea.Commands.Flowers
{
    public class DeleteFlowerCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
