using MediatR;
using Microsoft.EntityFrameworkCore;
using Orchidea.Data.Context;
using Orchidea.Data.Extensions;
using Orchidea.Domain.Models;
using Orchidea.Queries.Flowers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Orchidea.QueryHandlers.Flowers
{
    public class GetFlowersHandler : BaseQueryHandler, IRequestHandler<GetFlowersQuery, IEnumerable<Flower>>
    {
        public GetFlowersHandler(OrchideaContext context) : base(context) { }

        public async Task<IEnumerable<Flower>> Handle(GetFlowersQuery request, CancellationToken cancellationToken)
        {
            var flowers = await _context.Flowers
                .Select(f => f.ToDomain())
                .ToListAsync(cancellationToken);

            return flowers;
        }
    }
}
