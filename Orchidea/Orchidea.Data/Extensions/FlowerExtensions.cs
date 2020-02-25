using Orchidea.Domain.Models;

namespace Orchidea.Data.Extensions
{
    public static class FlowerExtensions
    {
        public static Flower ToDomain(this Models.Flower model)
        {
            return new Flower
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
