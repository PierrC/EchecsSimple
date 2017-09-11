using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChessApp.Game_Engin.Piece;

namespace ChessApp.Game_Engin
{
    public class ChessBoard
    {
        Square[,] board;
        
        public ChessBoard()
        {
            board = new Square[8,8];
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new Square(Dark);
                    Dark = !Dark;
                }
                Dark = !Dark;
            }
        }

        public void SetPieces()
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                board[i, 1].SetPiece(new Piece(PieceType.PAWN, Piece.Color.WHITE));
            }
            board[0, 0].SetPiece(new Piece(PieceType.ROOK, Piece.Color.WHITE));
            board[7, 0].SetPiece(new Piece(PieceType.ROOK, Piece.Color.WHITE));
            board[1, 0].SetPiece(new Piece(PieceType.KNIGHT, Piece.Color.WHITE));
            board[6, 0].SetPiece(new Piece(PieceType.KNIGHT, Piece.Color.WHITE));
            board[2, 0].SetPiece(new Piece(PieceType.BISHOP, Piece.Color.WHITE));
            board[5, 0].SetPiece(new Piece(PieceType.BISHOP, Piece.Color.WHITE));
            board[3, 0].SetPiece(new Piece(PieceType.QUEEN, Piece.Color.WHITE));
            board[4, 0].SetPiece(new Piece(PieceType.KING, Piece.Color.WHITE));
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                board[i, 6].SetPiece(new Piece(PieceType.PAWN, Piece.Color.BLACK));
            }
            board[0, 7].SetPiece(new Piece(PieceType.ROOK, Piece.Color.BLACK));
            board[7, 7].SetPiece(new Piece(PieceType.ROOK, Piece.Color.BLACK));
            board[1, 7].SetPiece(new Piece(PieceType.KNIGHT, Piece.Color.BLACK));
            board[6, 7].SetPiece(new Piece(PieceType.KNIGHT, Piece.Color.BLACK));
            board[2, 7].SetPiece(new Piece(PieceType.BISHOP, Piece.Color.BLACK));
            board[5, 7].SetPiece(new Piece(PieceType.BISHOP, Piece.Color.BLACK));
            board[3, 7].SetPiece(new Piece(PieceType.QUEEN, Piece.Color.BLACK));
            board[4, 7].SetPiece(new Piece(PieceType.KING, Piece.Color.BLACK));
        }
        
        public void MovesPiece(BoardPosition pStart, BoardPosition pEnd)
        {
            if(board[pStart.X, pStart.Y].HasPiece())
            {
                board[pEnd.X, pEnd.Y].SetPiece(board[pStart.X, pStart.Y].GetPiece());
                board[pStart.X, pStart.Y].RemovePiece();
            }
        }
        
        public Square[,] GetBoard()
        {
            return board;
        }

        public Boolean CheckWhiteKing()
        {
            Piece whiteKing = new Piece(Piece.PieceType.KING, Piece.Color.WHITE);
            for (int i = 0; i < GetBoard().Length; i++)
            {
                for (int j = 0; j < GetBoard().Length; j++)
                {
                    if (GetBoard()[i, j].HasPiece())
                    {
                        if (GetBoard()[i, j].GetPiece().GetPieceType().Equals(whiteKing))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean CheckBlackKing()
        {
            Piece blackKing = new Piece(Piece.PieceType.KING, Piece.Color.BLACK);
            for (int i = 0; i < GetBoard().Length; i++)
            {
                for (int j = 0; j < GetBoard().Length; j++)
                {
                    if (GetBoard()[i, j].HasPiece())
                    {
                        if (GetBoard()[i, j].GetPiece().GetPieceType().Equals(blackKing))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


    }
}
