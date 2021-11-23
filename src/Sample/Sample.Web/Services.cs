using Microsoft.Extensions.DependencyInjection;

namespace Sample.Web
{
    public static class Services
    {
        public static IServiceCollection InstallSampleServices(this IServiceCollection serviceCollection)
        {

            return serviceCollection;
        }

    }
}
