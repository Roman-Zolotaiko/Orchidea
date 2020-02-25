using Orchidea.Data.Context;

namespace Orchidea.QueryHandlers
{
    public abstract class BaseQueryHandler
    {
        protected readonly OrchideaContext _context;

        protected BaseQueryHandler(OrchideaContext context) => _context = context;
    }
}
