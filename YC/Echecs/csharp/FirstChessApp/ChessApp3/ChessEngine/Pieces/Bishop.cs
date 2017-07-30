using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Bishop : Piece
    {
        public Bishop(PlayerColors iColor, Position iPosition) : base(Types.BISHOP, iColor, iPosition)
        {

        }
    }
}
