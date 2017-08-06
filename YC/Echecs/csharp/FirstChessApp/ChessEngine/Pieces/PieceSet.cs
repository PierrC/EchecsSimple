using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class PieceSet :  List<Piece>
    {

        public PieceSet(Piece.PlayerColors color)
        {
            Boolean IsWhite = color == Piece.PlayerColors.WHITE;

            Position iPos;

            int Row0 = IsWhite ? 0 : 7;

            iPos = IsWhite ? new Position(4, Row0) : new Position(4, Row0);
            Add(new King(color, iPos));

            iPos = IsWhite ? new Position(3, Row0) : new Position(3, Row0);
            Add(new Queen(color, iPos));

            iPos = IsWhite ? new Position(2, Row0) : new Position(2, Row0);
            Add(new Bishop(color, iPos));
            iPos = IsWhite ? new Position(5, Row0) : new Position(5, Row0);
            Add(new Bishop(color, iPos));

            iPos = IsWhite ? new Position(1, Row0) : new Position(1, Row0);
            Add(new Knight(color, iPos));
            iPos = IsWhite ? new Position(6, Row0) : new Position(6, Row0);
            Add(new Knight(color, iPos));

            iPos = IsWhite ? new Position(0, Row0) : new Position(0, Row0);
            Add(new Rook(color, iPos));
            iPos = IsWhite ? new Position(7, Row0) : new Position(7, Row0);
            Add(new Rook(color, iPos));

            int Row1 = IsWhite ? 1 : 6;
            for (int i=0; i<8; i++)
            {
                iPos = IsWhite ? new Position(i, Row1) : new Position(i, Row1);
                Add(new Pawn(color, iPos));
            }
        }


        public void UpdatePossiblePositions(Chessboard iBoard)
        {
            foreach( Piece P in this)
            {
                P.UpdatePossiblePositions(iBoard);
            }
        }
    }
}
