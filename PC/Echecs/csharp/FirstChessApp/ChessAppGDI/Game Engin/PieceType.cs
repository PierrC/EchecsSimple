using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.Game_Engin
{
    public class PieceType
    {

        public enum Types
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING
        }

        public Types type;
        private MoveSet moves;

        public PieceType(Types type)
        {
            this.type = type;
            SetMoveSet();
        }

        public MoveSet GetMoveSet()
        {
            return moves;
        }

        private void SetMoveSet()
        {
            if(type == Types.BISHOP)
            {
                moves = new MoveSet(null, true);
                moves.addMove(new Move(1, 1, false, false));
                moves.addMove(new Move(1, -1, false, false));
                moves.addMove(new Move(-1, 1, false, false));
                moves.addMove(new Move(-1, -1, false, false));
            }
            else if( type == Types.KING)
            {
                moves = new MoveSet(null, false);
                moves.addMove(new Move(1, 1, false, false));
                moves.addMove(new Move(1, 0, false, false));
                moves.addMove(new Move(1, -1, false, false));
                moves.addMove(new Move(0, 1, false, false));
                moves.addMove(new Move(0, -1, false, false));
                moves.addMove(new Move(-1, 1, false, false));
                moves.addMove(new Move(-1, 0, false, false));
                moves.addMove(new Move(-1, 1, false, false));
            }
            else if (type == Types.QUEEN)
            {
                moves = new MoveSet(null, true);
                moves.addMove(new Move(1, 1, false, false));
                moves.addMove(new Move(1, 0, false, false));
                moves.addMove(new Move(1, -1, false, false));
                moves.addMove(new Move(0, 1, false, false));
                moves.addMove(new Move(0, -1, false, false));
                moves.addMove(new Move(-1, 1, false, false));
                moves.addMove(new Move(-1, 0, false, false));
                moves.addMove(new Move(-1, 1, false, false));
            }
            else if (type == Types.KNIGHT)
            {
                moves = new MoveSet(null, false);
                moves.addMove(new Move(2, 1, false, false));
                moves.addMove(new Move(2, -1, false, false));
                moves.addMove(new Move(-2, 1, false, false));
                moves.addMove(new Move(-2, -1, false, false));
                moves.addMove(new Move(1, 2, false, false));
                moves.addMove(new Move(1, -2, false, false));
                moves.addMove(new Move(-1, 2, false, false));
                moves.addMove(new Move(-1, -2, false, false));
            }
            else if (type == Types.ROOK)
            {
                moves = new MoveSet(null, true);
                moves.addMove(new Move(1, 0, false, false));
                moves.addMove(new Move(-1, 0, false, false));
                moves.addMove(new Move(0, 1, false, false));
                moves.addMove(new Move(0, -1, false, false));
            }
            else if (type == Types.PAWN)
            {
                moves = new MoveSet(null, false);
                moves.addMove(new Move(-1, 1, false, true));
                moves.addMove(new Move(0, 1, false, false));
                moves.addMove(new Move(0, 2, true, false));
                moves.addMove(new Move(1, 1, false, true));
            }
            else
            {
                
            }
        }

        

    }
}
