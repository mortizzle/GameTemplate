namespace Game.Core.Models
{
    public record ApplicationState
    {
        public EngineState EngineState { get; set; }
        public GameBoardState GameBoardState { get; set; }

        public static ApplicationState Initialise()
        {
            return new ApplicationState
            {
                EngineState = new EngineState(),
                GameBoardState = new GameBoardState()
            };
        }
    }
}
