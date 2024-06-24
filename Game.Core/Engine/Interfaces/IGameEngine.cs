using Game.Core.Models;

namespace Game.Core.Engine.Interfaces
{
    public interface IGameEngine
    {
        GameState UpdateGameState(GameState gameState);
        int GetTickLength(GameState gameState);
    }
}
