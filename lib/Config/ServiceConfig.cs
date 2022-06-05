using lib.Services;
using Microsoft.Extensions.DependencyInjection;

namespace lib.Config
{
    public class ServiceConfig
    {
        public static void ConfigureLibServices(IServiceCollection services) 
        {
            services.AddSingleton<ITestService, TestService>();
        }
    }
}