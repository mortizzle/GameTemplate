using Game.Core.Engine.Interfaces;
using Game.Core.Models;
using SkiaSharp;
using System;

namespace Game.Core.Engine
{
    internal class RenderEngine : IRenderEngine
    {
        public RenderEngine()
        {
        }
        public void Render(SKCanvas canvas, ApplicationState applicationState)
        {
            // Basic canvas background
            canvas.Clear(SKColors.CornflowerBlue);

            canvas.DrawRect(1020, 180, 720, 720, new SKPaint()
            {
                Color = SKColors.White,
                Style = SKPaintStyle.Fill,
                IsAntialias = true,
            });

            // Gameboard background
            canvas.DrawRect(1020, 180, 720, 720, new SKPaint()
            {
                Color = SKColors.CornflowerBlue.WithAlpha(0xD0),
                Style = SKPaintStyle.Fill,
                IsAntialias = true,
            });

            var stroke = SKColors.LightCyan;

            canvas.DrawLine(1020, 180, 1740, 180, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            // Gameboard Outline
            canvas.DrawLine(1740, 180, 1740, 900, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            canvas.DrawLine(1740, 900, 1020, 900, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            canvas.DrawLine(1020, 900, 1020, 180, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            // Gameboard strokes
            // Verticals
            canvas.DrawLine(1260, 180, 1260, 900, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            canvas.DrawLine(1500, 180, 1500, 900, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });


            // Horizontals
            canvas.DrawLine(1020, 420, 1740, 420, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            canvas.DrawLine(1020, 660, 1740, 660, new SKPaint()
            {
                Color = stroke,
                Style = SKPaintStyle.StrokeAndFill,
                StrokeWidth = 5,
                IsAntialias = true,
            });

            // End Gameboard

            // Draw crosses
            var gameBoardState = applicationState.GameBoardState;
            for(int x=0;x<1;x++)
                for(int y=0;y<2;y++)
                {
                    if (gameBoardState.getStateAt(x, y))
                        drawCross(canvas,x, y);
                }

        }
        private void drawCross(SKCanvas canvas, int cellX, int cellY)
        {
        }
    }
}
