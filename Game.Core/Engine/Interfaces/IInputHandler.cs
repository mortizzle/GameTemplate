using Game.Core.Models;
using Game.Core.Models.Enums;

namespace Game.Core.Engine.Interfaces
{
    public interface IInputHandler
    {
        ApplicationState HandleMouseClick(MouseButton mouseButton, int mouseX, int mouseY, ApplicationState applicationState);
        ApplicationState HandleKeyPress(char keyPressed, ApplicationState gameState);
    }
}