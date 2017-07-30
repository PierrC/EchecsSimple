using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Knight : Piece
    {
        public Knight(PlayerColors iColor, Position iPosition) : base( Types.KNIGHT, iColor, iPosition)
        {

        }
    }
}
