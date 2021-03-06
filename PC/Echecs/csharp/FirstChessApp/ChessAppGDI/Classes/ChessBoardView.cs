﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessBoardView
    {
        ChessBoard board;
        PieceView[,] viewBoard;

        public ChessBoardView()
        {
            board = new ChessBoard();
            viewBoard = new PieceView[8, 8];
            board.Restart();
            SetViewList();
        }

        public ChessBoard GetChessBoard()
        {
            return board;
        }

        public PieceView[,] GetViewBoard()
        {
            return viewBoard;
        }

        public void movePiece(BoardPosition pStart, BoardPosition pEnd)
        {
            board.movePiece(pStart, pEnd);
            viewBoard[pEnd.X, pEnd.Y] = viewBoard[pStart.X, pStart.Y];
            viewBoard[pStart.X, pStart.Y] = null;
        }

        private void SetViewList()
        {
            Boolean[,] boardBoolean = board.GetHasPiece();
            Piece[,] boardPiece = board.GetBoard();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board.GetHasPiece()[i, j])
                    {
                        viewBoard[i, j] = new PieceView(board.GetBoard()[i, j]);
                    }
                }
            }
        }

        public void DrawGame(Graphics g)
        {
            DrawBoard(g);
            DrawPieces(g);
        }


        /*   Temporary Variables
         */
        Font font = new Font("Times New Roman", 16);
        int square = 0; 
        /*
         */
        private void DrawBoard(Graphics g)
        {
            square = PositionAndPixels.square;
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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + (2 * i * square);
                    int p2 = square / 2 + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int p1 = square / 2 + square + (2 * i * square);
                    int p2 = square / 2 + square + (2 * j * square);
                    g.FillRectangle(Brushes.Black, p1, p2, square, square);
                }
            }
            
            for (int i = 1; i < 9; i++)
            {
                g.DrawString((9 - i).ToString(), font, Brushes.Black, square / 16, square * i - (square / 4));
                g.DrawString(Char.ConvertFromUtf32(65 + i - 1), font, Brushes.Black, square * i - (square / 4), square / 16);
            }

        }

        private void DrawPieces(Graphics g)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(board.GetHasPiece()[i, j])
                    {
                        Point point = PositionAndPixels.BoardPositionToPixels(new BoardPosition(i, j));
                        Image image = viewBoard[i, j].GetImage();

                        g.DrawImage(image , point.X, point.Y, PositionAndPixels.square, PositionAndPixels.square);
                    }
                }
            }
        }










    }
}
