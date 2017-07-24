using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class PieceSet
    {
        public List<Piece> Pieces;

        public PieceSet(Piece.PlayerColors color)
        {
            Boolean IsWhite = color == Piece.PlayerColors.WHITE;

            Pieces = new List<Piece>();
            Position iPos;

            int Column0 = IsWhite ? 0 : 7;

            iPos = IsWhite ? new Position(4, Column0) : new Position(Column0, 4);
            Pieces.Add(new Piece(Piece.Types.KING, color, iPos));

            iPos = IsWhite ? new Position(3, Column0) : new Position(3, Column0);
            Pieces.Add(new Piece(Piece.Types.QUEEN, color, iPos));

            iPos = IsWhite ? new Position(2, Column0) : new Position(2, Column0);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));
            iPos = IsWhite ? new Position(5, Column0) : new Position(5, Column0);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));

            iPos = IsWhite ? new Position(1, Column0) : new Position(1, Column0);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));
            iPos = IsWhite ? new Position(6, Column0) : new Position(6, Column0);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));

            iPos = IsWhite ? new Position(0, Column0) : new Position(0, Column0);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));
            iPos = IsWhite ? new Position(7, Column0) : new Position(7, Column0);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));

            int Column1 = IsWhite ? 1 : 6;
            for (int i=0; i<8; i++)
            {
                iPos = IsWhite ? new Position(i, Column1) : new Position(i, Column1);
                Pieces.Add(new Piece(Piece.Types.PAWN, color, iPos));
            }
        }
    }
}
