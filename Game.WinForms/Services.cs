using Microsoft.Extensions.DependencyInjection;

namespace Game.WinForms
{
    public static class Services
    {
        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<GameForm>();

            Core.Services.ConfigureServices(services);
        }
    }
}
