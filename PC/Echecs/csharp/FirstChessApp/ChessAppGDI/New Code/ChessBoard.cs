using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    /// <summary>
    /// TODO: clarify the scope of this class. Is a Chessboard or a ChessGame?
    /// </summary>
    public class ChessBoard
    {
        //TODO: A chessboard is not composed of 8x8 Piece. You need to create a specific class (Square?) that will also contain the hasPiece flag
        private Piece[,] squares;
        private Boolean[,] hasPiece;

        public Piece[,] Squares { get => squares; }
        public bool[,] HasPiece { get => hasPiece; }

        public ChessBoard()
        {
            squares = new Piece[8, 8];
            hasPiece = new Boolean[8, 8];
        }

        public void Restart()
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                Squares[i, 6] = new Piece(Piece.Types.PAWN, Piece.Colors.WHITE);
                HasPiece[i, 6] = true;
            }
            Squares[0, 7] = new Piece(Piece.Types.ROOK, Piece.Colors.WHITE);
            Squares[7, 7] = new Piece(Piece.Types.ROOK, Piece.Colors.WHITE);
            Squares[1, 7] = new Piece(Piece.Types.KNIGHT, Piece.Colors.WHITE);
            Squares[6, 7] = new Piece(Piece.Types.KNIGHT, Piece.Colors.WHITE);
            Squares[2, 7] = new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE);
            Squares[5, 7] = new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE);
            Squares[3, 7] = new Piece(Piece.Types.QUEEN, Piece.Colors.WHITE);
            Squares[4, 7] = new Piece(Piece.Types.KING, Piece.Colors.WHITE);
            HasPiece[0, 7] = true;
            HasPiece[1, 7] = true;
            HasPiece[2, 7] = true;
            HasPiece[3, 7] = true;
            HasPiece[4, 7] = true;
            HasPiece[5, 7] = true;
            HasPiece[6, 7] = true;
            HasPiece[7, 7] = true;
            
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                Squares[i, 1] = new Piece(Piece.Types.PAWN, Piece.Colors.BLACK);
                HasPiece[i, 1] = true;
            }
            Squares[0, 0] = new Piece(Piece.Types.ROOK, Piece.Colors.BLACK);
            Squares[7, 0] = new Piece(Piece.Types.ROOK, Piece.Colors.BLACK);
            Squares[1, 0] = new Piece(Piece.Types.KNIGHT, Piece.Colors.BLACK);
            Squares[6, 0] = new Piece(Piece.Types.KNIGHT, Piece.Colors.BLACK);
            Squares[2, 0] = new Piece(Piece.Types.BISHOP, Piece.Colors.BLACK);
            Squares[5, 0] = new Piece(Piece.Types.BISHOP, Piece.Colors.BLACK);
            Squares[3, 0] = new Piece(Piece.Types.QUEEN, Piece.Colors.BLACK);
            Squares[4, 0] = new Piece(Piece.Types.KING, Piece.Colors.BLACK);
            HasPiece[0, 0] = true;
            HasPiece[1, 0] = true;
            HasPiece[2, 0] = true;
            HasPiece[3, 0] = true;
            HasPiece[4, 0] = true;
            HasPiece[5, 0] = true;
            HasPiece[6, 0] = true;
            HasPiece[7, 0] = true;
            
        }

        //public Piece[,] GetBoard()
        //{
        //    return Squares;
        //}

        //public Boolean[,] GetHasPiece()
        //{
        //    return HasPiece;
        //}

        public static Piece.Colors OtherColor(Piece.Colors pColor)
        {
            if (pColor.Equals(Piece.Colors.WHITE))
            {
                return Piece.Colors.BLACK;
            }
            else
            {
                return Piece.Colors.WHITE;
            }
        }

        private void removePiece(BoardPosition pPosition)
        {
            Squares[pPosition.Row, pPosition.Column] = null;
            HasPiece[pPosition.Row, pPosition.Column] = false;
        }

        private void setPiece(BoardPosition pPosition, Piece pPiece)
        {
            Squares[pPosition.Row, pPosition.Column] = pPiece;
            HasPiece[pPosition.Row, pPosition.Column] = true;
        }

        public void movePiece(BoardPosition pStart, BoardPosition pEnd)
        {
            
            if (HasPiece[pStart.Row, pStart.Column])
            {
                Piece transferPiece = Squares[pStart.Row, pStart.Column];
                Squares[pEnd.Row, pEnd.Column] = transferPiece;
                Squares[pStart.Row, pStart.Column] = null;

                HasPiece[pStart.Row, pStart.Column] = false;
                HasPiece[pEnd.Row, pEnd.Column] = true;
            }
        }



    }
}
