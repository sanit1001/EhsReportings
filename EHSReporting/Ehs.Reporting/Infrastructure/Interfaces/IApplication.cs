using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Infrastructure
{
    interface IApplication
    {
        Task<int> Run();
    }
}
