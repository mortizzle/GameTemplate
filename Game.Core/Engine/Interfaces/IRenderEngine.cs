using Game.Core.Models;
using SkiaSharp;

namespace Game.Core.Engine.Interfaces
{
    public interface IRenderEngine
    {
        void Render(SKCanvas canvas, ApplicationState applicationState);
    }
}