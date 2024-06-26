using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using Game.Core.Models.Enums;

namespace Game.Core.Engine
{
    internal class InputHandler: IInputHandler
    {
        public ApplicationState HandleMouseClick(MouseButton mouseButton, int mouseX, int mouseY, ApplicationState applicationState)
        {
            if (mouseButton  == MouseButton.Left)
            {
                return applicationState with
                {
                    GameBoardState = handleLeftClick(mouseX, mouseY, applicationState.GameBoardState)
                };
            }
            return applicationState;
        }

        public ApplicationState HandleKeyPress(char keyPressed, ApplicationState applicationState)
        {
            return applicationState;
        }

        private GameBoardState handleLeftClick(int mouseX, int mouseY, GameBoardState gameBoardState) 
        {
            if (mouseX > 1020 && mouseX < 1740 && mouseY > 180 && mouseY < 900)
            {
                int boardX = mouseX - 1020;
                int boardY = mouseY - 180;

                int cellX = boardX / 240;
                int cellY = boardY / 240;

                gameBoardState.setStateAt(cellX, cellY, true);
            }

            return gameBoardState;
        }   
    }
}
