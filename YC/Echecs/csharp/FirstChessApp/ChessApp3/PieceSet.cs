using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class PieceSet
    {
        List<Piece> Pieces;

        public PieceSet(Piece.PlayerColors color)
        {
            Boolean IsWhite = color == Piece.PlayerColors.WHITE;

            Pieces = new List<Piece>();
            Position iPos;

            int Row0 = IsWhite ? 0 : 7;

            iPos = IsWhite ? new Position(Row0, 4) : new Position(Row0, 4);
            Pieces.Add(new Piece(Piece.Types.KING, color, iPos));

            iPos = IsWhite ? new Position(Row0, 3) : new Position(Row0, 3);
            Pieces.Add(new Piece(Piece.Types.QUEEN, color, iPos));

            iPos = IsWhite ? new Position(Row0, 2) : new Position(Row0, 2);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));
            iPos = IsWhite ? new Position(Row0, 5) : new Position(Row0, 5);
            Pieces.Add(new Piece(Piece.Types.BISHOP, color, iPos));

            iPos = IsWhite ? new Position(Row0, 1) : new Position(Row0, 1);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));
            iPos = IsWhite ? new Position(Row0, 6) : new Position(Row0, 6);
            Pieces.Add(new Piece(Piece.Types.KNIGHT, color, iPos));

            iPos = IsWhite ? new Position(Row0, 0) : new Position(Row0, 0);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));
            iPos = IsWhite ? new Position(Row0, 7) : new Position(Row0, 7);
            Pieces.Add(new Piece(Piece.Types.ROOK, color, iPos));

            int Row1 = IsWhite ? 1 : 6;
            for (int i=0; i<8; i++)
            {
                iPos = IsWhite ? new Position(Row1, i) : new Position(Row1, i);
                Pieces.Add(new Piece(Piece.Types.PAWN, color, iPos));
            }
        }
    }
}
