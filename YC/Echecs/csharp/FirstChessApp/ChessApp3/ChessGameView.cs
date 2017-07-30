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
        Graphics graphix_ = null;
        PositionPixel Pixel2Position_ = null;
        private ChessGame Game_;
        public Color DarkColor = Color.DarkBlue;
        public Color LightColor = Color.LightGoldenrodYellow;

        public ChessGame Game { get => Game_;}
        public Graphics Graphix { get => graphix_; set => graphix_ = value; }
        public PositionPixel Pixel2Position { get => Pixel2Position_; set => Pixel2Position_ = value; }

        public ChessGameView(ChessGame IGame)
        {
            Game_ = IGame;
        }

        public void GameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Redraw Game From notification.");
            if (sender is ChessGame)
                DrawGame();
        }


        public void DrawGame()
        {
            if (Game_ == null)
                return;
            if (Graphix == null)
                return;
            if (Pixel2Position == null)
                return;

            DrawChessboard(Game.Board, Graphix, Pixel2Position);
            HighlightSelectedPiece(Game.SelectedPiece, Graphix, Pixel2Position);
        }

        private void DrawChessboard(Chessboard Board, Graphics g, PositionPixel PP)
        {
            if (Board == null)
                return;
            //Point UpperCorner = PP.GetPositionUpperCorner(selectedPiece.Position);
            //g.FillRectangle(Brush, UpperCorner.X, UpperCorner.Y, PP.PixelSquare, PP.PixelSquare);

            //SolidBrush blueBrush = new SolidBrush(Color.Blue);

            //// Create location and size of rectangle.
            //int x = 0;
            //int y = 0;
            //int width = 200;
            //int height = 200;

            //// Fill rectangle to screen.
            //g.FillRectangle(blueBrush, x, y, width, height);

            SolidBrush DarkBrush = new SolidBrush(this.DarkColor);
            SolidBrush LightBrush = new SolidBrush(this.LightColor);
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square Cell = Board.Squares[i, j];
                    Dark = Cell.IsDark;
                    Point UpperCorner = PP.GetPositionUpperCorner(Cell.Position);
                    g.FillRectangle(Dark ? DarkBrush : LightBrush, UpperCorner.X, UpperCorner.Y, PP.PixelSquare, PP.PixelSquare);
                    if (Cell.HasPiece())
                    {
                        Piece P = Cell.Piece;
                        UpperCorner = PP.GetPositionUpperCorner(P.Position);
                        int PieceMargin = 2;
                        int PieceDim = PP.PixelSquare - 2 * PieceMargin;
                        g.DrawImage(P.Image, UpperCorner.X + PieceMargin, UpperCorner.Y + PieceMargin, PieceDim, PieceDim);
                    }
                }
            }
        }

        private void HighlightSelectedPiece(Piece selectedPiece, Graphics g, PositionPixel PP)
        {
            if (selectedPiece == null)
                return;

            SolidBrush redBrush = new SolidBrush(Color.Red);
            int Width = 4;
            Pen HighlightPen = new Pen(redBrush);
            HighlightPen.Width = Width;
            HighlightPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            Point UpperCorner = PP.GetPositionUpperCorner(selectedPiece.Position);
            int PieceMargin = Width/2;
            int PieceDim = PP.PixelSquare - 2 * PieceMargin;
            g.DrawRectangle(HighlightPen, UpperCorner.X + PieceMargin, UpperCorner.Y + PieceMargin, PieceDim, PieceDim);
        }

    }
}
