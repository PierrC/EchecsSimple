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

            DrawChessboard(Game.Board, g, PP);

            DrawPieceSet(Game.BlackPieces, g, PP);
            DrawPieceSet(Game.WhitePieces, g, PP);

        }

        private void DrawChessboard(Chessboard Board, Graphics g, PositionPixel PP)
        {
            if (Board == null)
                return;

            SolidBrush DarkBrush = new SolidBrush(this.DarkColor);
            SolidBrush LightBrush = new SolidBrush(this.LightColor);
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square Cell = Board.Squares[i, j];
                    Dark = Cell.IsBlack;
                    Point UpperCorner = PP.GetPositionUpperCorner(Cell.Position);
                    g.FillRectangle(Dark ? DarkBrush : LightBrush, UpperCorner.X, UpperCorner.Y, PP.PixelSquare, PP.PixelSquare);
                }
            }
        }

        private void DrawPieceSet(PieceSet Set, Graphics g, PositionPixel PP)
        {
            if (Set == null)
                return;

            foreach(Piece P in Set.Pieces)
            {
                if (P.Position.IsValid && P.Image != null)
                {
                    Point UpperCorner = PP.GetPositionUpperCorner(P.Position);
                    int PieceMargin = 2;
                    int PieceDim = PP.PixelSquare - 2 * PieceMargin;
                    g.DrawImage(P.Image, UpperCorner.X + PieceMargin, UpperCorner.Y + PieceMargin, PieceDim, PieceDim);
                }
            }
        }
    }
}
