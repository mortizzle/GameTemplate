using Game.Core.Models.Enums;

namespace Game.Core.Models
{
    public record GameState
    {
        public bool Paused { get; set; }
        public long GameTicks { get; set; }
        public GameSpeed GameSpeed { get; set; }
    }
}

