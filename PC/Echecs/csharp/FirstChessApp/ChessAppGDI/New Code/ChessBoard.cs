using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessBoard
    {
        Piece[,] board;
        Boolean[,] hasPiece;

        public ChessBoard()
        {
            board = new Piece[8, 8];
            hasPiece = new Boolean[8, 8];
        }

        public void Restart()
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                board[i, 6] = new Piece(Piece.PieceType.PAWN, Piece.Color.WHITE);
                hasPiece[i, 6] = true;
            }
            board[0, 7] = new Piece(Piece.PieceType.ROOK, Piece.Color.WHITE);
            board[7, 7] = new Piece(Piece.PieceType.ROOK, Piece.Color.WHITE);
            board[1, 7] = new Piece(Piece.PieceType.KNIGHT, Piece.Color.WHITE);
            board[6, 7] = new Piece(Piece.PieceType.KNIGHT, Piece.Color.WHITE);
            board[2, 7] = new Piece(Piece.PieceType.BISHOP, Piece.Color.WHITE);
            board[5, 7] = new Piece(Piece.PieceType.BISHOP, Piece.Color.WHITE);
            board[3, 7] = new Piece(Piece.PieceType.QUEEN, Piece.Color.WHITE);
            board[4, 7] = new Piece(Piece.PieceType.KING, Piece.Color.WHITE);
            hasPiece[0, 7] = true;
            hasPiece[1, 7] = true;
            hasPiece[2, 7] = true;
            hasPiece[3, 7] = true;
            hasPiece[4, 7] = true;
            hasPiece[5, 7] = true;
            hasPiece[6, 7] = true;
            hasPiece[7, 7] = true;
            
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                board[i, 1] = new Piece(Piece.PieceType.PAWN, Piece.Color.BLACK);
                hasPiece[i, 1] = true;
            }
            board[0, 0] = new Piece(Piece.PieceType.ROOK, Piece.Color.BLACK);
            board[7, 0] = new Piece(Piece.PieceType.ROOK, Piece.Color.BLACK);
            board[1, 0] = new Piece(Piece.PieceType.KNIGHT, Piece.Color.BLACK);
            board[6, 0] = new Piece(Piece.PieceType.KNIGHT, Piece.Color.BLACK);
            board[2, 0] = new Piece(Piece.PieceType.BISHOP, Piece.Color.BLACK);
            board[5, 0] = new Piece(Piece.PieceType.BISHOP, Piece.Color.BLACK);
            board[3, 0] = new Piece(Piece.PieceType.QUEEN, Piece.Color.BLACK);
            board[4, 0] = new Piece(Piece.PieceType.KING, Piece.Color.BLACK);
            hasPiece[0, 0] = true;
            hasPiece[1, 0] = true;
            hasPiece[2, 0] = true;
            hasPiece[3, 0] = true;
            hasPiece[4, 0] = true;
            hasPiece[5, 0] = true;
            hasPiece[6, 0] = true;
            hasPiece[7, 0] = true;
            
        }

        public Piece[,] GetBoard()
        {
            return board;
        }

        public Boolean[,] GetHasPiece()
        {
            return hasPiece;
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
            board[pPosition.X, pPosition.Y] = null;
            hasPiece[pPosition.X, pPosition.Y] = false;
        }

        private void setPiece(BoardPosition pPosition, Piece pPiece)
        {
            board[pPosition.X, pPosition.Y] = pPiece;
            hasPiece[pPosition.X, pPosition.Y] = true;
        }

        public void movePiece(BoardPosition pStart, BoardPosition pEnd)
        {
            if (hasPiece[pEnd.X, pEnd.Y] && board[pEnd.X, pEnd.Y].getColor().Equals(board[pStart.X, pStart.Y].getColor()) )
            {

            }
            else if (hasPiece[pStart.X, pStart.Y])
            {
                board[pEnd.X, pEnd.Y] = board[pStart.X, pStart.Y];
                board[pStart.X, pStart.Y] = null;

                hasPiece[pStart.X, pStart.Y] = false;
                hasPiece[pEnd.X, pEnd.Y] = true;
            }
        }



    }
}
