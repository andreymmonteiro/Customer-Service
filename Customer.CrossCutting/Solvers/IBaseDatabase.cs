using Microsoft.Extensions.DependencyInjection;

namespace Customer.CrossCutting.Solvers
{
    public interface IBaseDatabase
    {
        void IncludeDataBase(IServiceCollection service);
    }
}
