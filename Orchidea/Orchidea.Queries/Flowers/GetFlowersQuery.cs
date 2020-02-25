using MediatR;
using Orchidea.Domain.Models;
using System.Collections.Generic;

namespace Orchidea.Queries.Flowers
{
    public class GetFlowersQuery : IRequest<IEnumerable<Flower>>
    {
    }
}
