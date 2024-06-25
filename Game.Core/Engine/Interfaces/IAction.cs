using Game.Core.Models;

namespace Game.Core.Engine.Interfaces
{
    internal interface IAction
    {
        ApplicationState Execute(ApplicationState state);  
    }
}
