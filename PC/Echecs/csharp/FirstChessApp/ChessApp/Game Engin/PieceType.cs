using ChessApp.Game_Engin.MoveInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    class PieceType
    {
        public enum PieceName
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING,
        }

        PieceName aName;
        MoveBehavior aMove;

        PieceType(PieceName pName)
        {
            aName = pName;
        }

        private void SetMoveBehavior()
        {
            if(aName == PieceName.BISHOP)
            {
                aMove = new BishopMoves();
            }
            else if(aName == PieceName.KING)
            {
                aMove = new KingMoves();
            }
            else if (aName == PieceName.KNIGHT)
            {
                aMove = new KnightMoves();
            }
            else if (aName == PieceName.PAWN)
            {
                aMove = new PawnMoves();
            }
            else if (aName == PieceName.QUEEN)
            {
                aMove = new QueenMoves();
            }
            else if (aName == PieceName.ROOK)
            {
                aMove = new RookMoves();
            }
            else
            {
                aMove = null;
            }
        }

    }
}
