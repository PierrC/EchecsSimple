using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Queen : Piece
    {
        public Queen(PlayerColors iColor, Position iPosition) : base(Types.QUEEN, iColor, iPosition)
        {

        }
    }
}
