using Microsoft.Extensions.DependencyInjection;
using Game.Core.Engine.Interfaces;
using Game.Core.Engine;

namespace Game.Core
{
    public static class Services
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IInputHandler, InputHandler>()
                .AddScoped<IRenderEngine, RenderEngine>()
                .AddScoped<IGameEngine, GameEngine>();
        }
    }
}
