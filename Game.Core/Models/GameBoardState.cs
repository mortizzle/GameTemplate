namespace Game.Core.Models
{
    public class GameBoardState
    {
        private bool[][] _state;
        public string name { get; set; }

        public GameBoardState()
        {
            _state = new[] { new[] { false, false, false }, new[] { false, false, false }, new[] { false, false, false } };
        }

        public void setStateAt(int x, int y, bool state)
        {
            _state[x][y] = state;
        }

        public bool getStateAt(int x, int y)
        {
            return _state[x][y];
        }
    }
}
