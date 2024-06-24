using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using Game.Core.Models.Enums;

namespace Game.Core.Engine
{
    internal class InputHandler: IInputHandler
    {
        public ApplicationState HandleMouseClick(MouseButton mouseButton, int mouseX, int mouseY, ApplicationState applicationState)
        {
            return applicationState;
        }

        public ApplicationState HandleKeyPress(char keyPressed, ApplicationState applicationState)
        {
            return applicationState;
        }
    }
}
