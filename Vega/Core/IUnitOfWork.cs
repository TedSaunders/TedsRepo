using System.Threading.Tasks;

namespace Vega.Core
{
    interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
