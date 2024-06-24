using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using Game.Core.Models.Enums;
using System;

namespace Game.Core
{
    internal class GameEngine : IGameEngine
    {
        public GameState UpdateGameState(GameState gameState)
        {
            if (gameState.Paused) return gameState;

            return gameState with
            {
                GameTicks = gameState.GameTicks + 1
            };
        }

        public int GetTickLength(GameState gameState)
        {
            return gameState.GameSpeed switch
            {
                GameSpeed.Snail => 500,
                GameSpeed.Slow => 150,
                GameSpeed.Normal => 16,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
