using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Pawn : Piece
    {
        public Pawn(PlayerColors iColor, Position iPosition) : base(Types.PAWN, iColor, iPosition)
        {

        }
    }
}
