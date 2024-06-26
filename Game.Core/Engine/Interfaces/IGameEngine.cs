using Game.Core.Models;

namespace Game.Core.Engine.Interfaces
{
    public interface IGameEngine
    {
        EngineState UpdateEngineState(EngineState engineState);
        int GetTickLength(EngineState engineState);
    }
}
