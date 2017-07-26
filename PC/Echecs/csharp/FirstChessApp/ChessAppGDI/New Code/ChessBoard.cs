using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessBoard
    {
        Square[,] board;

        public ChessBoard()
        {
            board = new Square[8, 8];

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    board[i,j] = new Square();
                }
            }
        }

        public void Restart()
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                board[i, 6].SetPiece( new Piece(Piece.PieceType.PAWN, Piece.Color.WHITE));
            }
            board[0, 7].SetPiece(new Piece(Piece.PieceType.ROOK, Piece.Color.WHITE));
            board[7, 7].SetPiece(new Piece(Piece.PieceType.ROOK, Piece.Color.WHITE));
            board[1, 7].SetPiece(new Piece(Piece.PieceType.KNIGHT, Piece.Color.WHITE));
            board[6, 7].SetPiece(new Piece(Piece.PieceType.KNIGHT, Piece.Color.WHITE));
            board[2, 7].SetPiece(new Piece(Piece.PieceType.BISHOP, Piece.Color.WHITE));
            board[5, 7].SetPiece(new Piece(Piece.PieceType.BISHOP, Piece.Color.WHITE));
            board[3, 7].SetPiece(new Piece(Piece.PieceType.QUEEN, Piece.Color.WHITE));
            board[4, 7].SetPiece(new Piece(Piece.PieceType.KING, Piece.Color.WHITE));
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                board[i, 1].SetPiece(new Piece(Piece.PieceType.PAWN, Piece.Color.BLACK));
            }
            board[0, 0].SetPiece(new Piece(Piece.PieceType.ROOK, Piece.Color.BLACK));
            board[7, 0].SetPiece(new Piece(Piece.PieceType.ROOK, Piece.Color.BLACK));
            board[1, 0].SetPiece(new Piece(Piece.PieceType.KNIGHT, Piece.Color.BLACK));
            board[6, 0].SetPiece(new Piece(Piece.PieceType.KNIGHT, Piece.Color.BLACK));
            board[2, 0].SetPiece(new Piece(Piece.PieceType.BISHOP, Piece.Color.BLACK));
            board[5, 0].SetPiece(new Piece(Piece.PieceType.BISHOP, Piece.Color.BLACK));
            board[3, 0].SetPiece(new Piece(Piece.PieceType.QUEEN, Piece.Color.BLACK));
            board[4, 0].SetPiece(new Piece(Piece.PieceType.KING, Piece.Color.BLACK));
        }

        public Square[,] GetBoard()
        {
            return board;
        }
        
        public static Piece.Color OtherColor(Piece.Color pColor)
        {
            if (pColor.Equals(Piece.Color.WHITE))
            {
                return Piece.Color.BLACK;
            }
            else
            {
                return Piece.Color.WHITE;
            }
        }

        private void removePiece(BoardPosition pPosition)
        {
            board[pPosition.X, pPosition.Y].RemovePiece();
        }

        private void setPiece(BoardPosition pPosition, Piece pPiece)
        {
            board[pPosition.X, pPosition.Y].SetPiece(pPiece);
        }

        public void movePiece(BoardPosition pStart, BoardPosition pEnd)
        {
            
            if (board[pStart.X, pStart.Y].HasPiece())
            {
                Piece transferPiece = board[pStart.X, pStart.Y].GetPiece();
                board[pEnd.X, pEnd.Y].SetPiece(transferPiece);
                board[pStart.X, pStart.Y].RemovePiece();
                
            }
        }



    }
}
