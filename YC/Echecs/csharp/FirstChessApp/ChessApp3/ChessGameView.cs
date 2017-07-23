using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessApp3
{
    public class ChessGameView
    {
        private ChessGame Game_;
        public Color DarkColor = Color.DarkBlue;
        public Color LightColor = Color.LightGoldenrodYellow;

        public ChessGame Game { get => Game_;}

        public ChessGameView(ChessGame IGame)
        {
            Game_ = IGame;
        }

        public void DrawGame(Graphics g, PositionPixel PP)
        {
            if (Game == null)
                return;

            if (Game.Board != null)
            {
                DrawChessboard(Game.Board, g, PP);
            }
            if (Game.BlackPieces != null)
            {
                DrawPieceSet(Game.BlackPieces, g, PP);
            }
            if (Game.WhitePieces != null)
            {
                DrawPieceSet(Game.WhitePieces, g, PP);
            }
        }

        private void DrawChessboard(Chessboard Board, Graphics g, PositionPixel PP)
        {
            SolidBrush DarkBrush = new SolidBrush(this.DarkColor);
            SolidBrush LightBrush = new SolidBrush(this.LightColor);
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square Cell = Board.Squares[i, j];
                    Dark = Cell.IsBlack;
                    int SquareWidth = PP.PixelSquare;
                    Point UpperCorner = PP.GetPositionUpperCorner(Cell.Position);
                    g.FillRectangle(Dark ? DarkBrush : LightBrush, UpperCorner.X, UpperCorner.Y, SquareWidth, SquareWidth);
                    Dark = !Dark;
                }
            }
        }

        private void DrawPieceSet(PieceSet Set, Graphics g, PositionPixel PP)
        {

        }
    }
}
