using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using Game.Core.Models.Enums;
using System;

namespace Game.Core
{
    internal class GameEngine : IGameEngine
    {
        public EngineState UpdateEngineState(EngineState engineState)
        {
            if (engineState.Paused) return engineState;

            return engineState with
            {
                GameTicks = engineState.GameTicks + 1
            };
        }

        public int GetTickLength(EngineState engineState)
        {
            return engineState.GameSpeed switch
            {
                GameSpeed.Snail => 500,
                GameSpeed.Slow => 150,
                GameSpeed.Normal => 16,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
