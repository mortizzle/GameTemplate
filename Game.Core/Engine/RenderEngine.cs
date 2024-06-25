using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using SkiaSharp;

namespace Game.Core.Engine
{
    internal class RenderEngine : IRenderEngine
    {
        public RenderEngine()
        {
        }
        public void Render(SKCanvas canvas, ApplicationState applicationState)
        {
            canvas.Clear(SKColors.LightGreen);
        }
    }
}
