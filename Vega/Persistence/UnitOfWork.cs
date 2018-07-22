using System.Threading.Tasks;
using vega.Core;
using Vega.Persistence;

namespace vega.Persistence
{
    public class UnitOfWork
    {
        private readonly VegaDbContext context;

        public UnitOfWork(VegaDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}