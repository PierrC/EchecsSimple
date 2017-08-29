using ChessApp.Game_Engin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.View_Engin
{
    public class ChessBoardView
    {
        SquareView[,] aSquaresView;
        ChessBoard aBoard;
        PieceManipulatorView aPieceManipulatorView;

        Brush aWhiteSquareBrushes, aBlackSquareBrushes;
        Font font = new Font("Times New Roman", 16);

        public ChessBoardView(ChessBoard pBoard, PieceManipulator pPieceManipulator, Brush pWhiteSquareBrushes, Brush pBlackSquareBrushes)
        {
            aBoard = pBoard;
            aSquaresView = new SquareView[8, 8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    aSquaresView[i, j] = new SquareView(aBoard.GetBoard()[i, j]);
                }
            }
            aPieceManipulatorView = new PieceManipulatorView(pPieceManipulator);
            aWhiteSquareBrushes = pWhiteSquareBrushes;
            aBlackSquareBrushes = pBlackSquareBrushes;
        }

        public void SetWhiteBrush(Brush pBrush)
        {
            aWhiteSquareBrushes = pBrush;
        }

        public void SetBlackBrush(Brush pBrush)
        {
            aBlackSquareBrushes = pBrush;
        }

        public void DrawGame(Graphics g)
        {
            DrawBoard(g);
            DrawPieces(g);
            DrawPossibleMoves(g);
        }

        private void DrawBoard(Graphics g)
        {
            int square = PositionAndPixels.square;
            for (int i = 0; i < 9; i++)
            {
                // Vertical lines
                Point p1 = new Point(square / 2, square / 2 + square * i);
                Point p2 = new Point(square / 2 + square * 8, square / 2 + square * i);
                g.DrawLine(Pens.Black, p1, p2);

                // Horizontal lines
                Point p3 = new Point(square / 2 + square * i, square / 2);
                Point p4 = new Point(square / 2 + square * i, square / 2 + square * 8);
                g.DrawLine(Pens.Black, p3, p4);
            }
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    int p1 = square / 2 + (i * square);
                    int p2 = square / 2 + (j * square);
                    if (aBoard.GetBoard()[i, j].SquareIsDark())
                    {
                        g.FillRectangle(aBlackSquareBrushes, p1, p2, square, square);
                    }
                    else
                    {
                        g.FillRectangle(aWhiteSquareBrushes, p1, p2, square, square);
                    }
                }
            }
            
            for (int i = 1; i < 9; i++)
            {
                g.DrawString((i).ToString(), font, aBlackSquareBrushes, square / 16, square * i - (square / 4));
                g.DrawString(Char.ConvertFromUtf32(65 + i - 1), font, aBlackSquareBrushes, square * i - (square / 4), square / 16);
            }
            /*
            if (isSelecting)
            {
                DrawSelectedSquares(g);
            }
            */
        }
        
        private void DrawPieces(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (aBoard.GetBoard()[i, j].HasPiece())
                    {
                        Point point = PositionAndPixels.BoardPositionToPixels(new BoardPosition(i, j));
                        aSquaresView[i, j].drawPiece(g, point);
                    }
                }
            }
        }

        private void DrawPossibleMoves(Graphics g)
        {
            aPieceManipulatorView.DrawPossibleMoves(g);
        }


    }
}
