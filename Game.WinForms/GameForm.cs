
using SkiaSharp.Views.Desktop;
using Game.Core.Models.Enums;
using Game.Core.Models;
using Game.Core.Engine.Interfaces;

namespace Game
{
    internal partial class GameForm : Form
    {
        private readonly IInputHandler _inputHandler;
        private readonly IRenderEngine _renderer;
        private readonly IGameEngine _gameEngine;

        private readonly SKControl _skView;
        private ApplicationState _applicationState;
        private bool _runRenderLoop = true;

        public GameForm(IInputHandler inputHandler, IRenderEngine renderer, IGameEngine gameEngine)
        {
            _inputHandler = inputHandler;
            _renderer = renderer;
            _gameEngine = gameEngine;

            Text = "My Game";
            ClientSize = new Size(1920, 1080);

            _skView = new SKControl();
            _skView.Dock = DockStyle.Fill;
            Controls.Add(_skView);

            _skView.PaintSurface += Render;
            _skView.MouseClick += HandleMouseClick;
            _skView.KeyPress += HandleKeyPress;

            _applicationState = ApplicationState.Initialise();

            _ = PresentLoop();
            
        }

        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            _applicationState = _inputHandler.HandleMouseClick(ConvertButtons(e.Button), e.X, e.Y, _applicationState);
        }

        private void HandleKeyPress(Object sender, KeyPressEventArgs e)
        {
            _applicationState = _inputHandler.HandleKeyPress(e.KeyChar, _applicationState);
        }

        private void Render(object sender, SKPaintSurfaceEventArgs e)
        {
            _renderer.Render(e.Surface.Canvas, _applicationState);
        }

        private async Task PresentLoop()
        {
            while (_runRenderLoop)
            {
                _applicationState = _applicationState with { EngineState = _gameEngine.UpdateEngineState(_applicationState.EngineState)};
                _skView.Invalidate();

                await Task.Delay(_gameEngine.GetTickLength(_applicationState.EngineState)).ConfigureAwait(true);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _runRenderLoop = false;
                _skView.Dispose();
            }
            base.Dispose(disposing);
        }

        private MouseButton ConvertButtons(MouseButtons mouseButtons)
        {
            return mouseButtons switch
            {
                MouseButtons.Left => MouseButton.Left,
                MouseButtons.Right => MouseButton.Right,
                _ => throw new NotImplementedException()
            };
        }
    }
}
