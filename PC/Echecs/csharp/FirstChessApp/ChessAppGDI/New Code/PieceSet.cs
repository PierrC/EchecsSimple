using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class PieceSet
    {
        public List<Piece> Pieces;

        public PieceSet(Piece.Colors color)
        {
            Boolean IsWhite = color == Piece.Colors.WHITE;

            Pieces = new List<Piece>();
            BoardPosition iPos;

            int Column0 = IsWhite ? 0 : 7;

            iPos = IsWhite ? new BoardPosition(4, Column0) : new BoardPosition(4, Column0);
            Pieces.Add(new Piece(Piece.Types.KING, color, iPos));

            iPos = IsWhite ? new BoardPosition(3, Column0) : new BoardPosition(3, Column0);
            Pieces.Add(new Piece(Piece.Types.QUEEN, color, iPos));

            iPos = IsWhite ? new BoardPosition(2, Column0) : new BoardPosition(2, Column0);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));
            iPos = IsWhite ? new BoardPosition(5, Column0) : new BoardPosition(5, Column0);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));

            iPos = IsWhite ? new BoardPosition(1, Column0) : new BoardPosition(1, Column0);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));
            iPos = IsWhite ? new BoardPosition(6, Column0) : new BoardPosition(6, Column0);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));

            iPos = IsWhite ? new BoardPosition(0, Column0) : new BoardPosition(0, Column0);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));
            iPos = IsWhite ? new BoardPosition(7, Column0) : new BoardPosition(7, Column0);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));

            int Column1 = IsWhite ? 1 : 6;
            for (int i = 0; i < 8; i++)
            {
                iPos = IsWhite ? new BoardPosition(i, Column1) : new BoardPosition(i, Column1);
                Pieces.Add(new Piece(Piece.Types.PAWN, color, iPos));
            }
        }
    }
}
