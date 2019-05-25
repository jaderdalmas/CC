using CC.Repositories;
using CC.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CC.StartUp
{
    public static class Repository
    {
        public static void Register(IServiceCollection services)
        {
            // Service
            services.AddScoped(typeof(IContaCorrenteService), typeof(ContaCorrenteService));

            // Repository
            services.AddScoped(typeof(IContaCorrenteRepository), typeof(ContaCorrenteRepository));
        }
    }
}
