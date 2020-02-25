using Orchidea.Data.Context;

namespace Orchidea.CommandHandlers
{
    public class BaseCommandHandler
    {
        protected readonly OrchideaContext _context;

        public BaseCommandHandler(OrchideaContext context)
        {
            _context = context;
        }
    }
}
