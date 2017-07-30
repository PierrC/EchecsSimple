using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class King : Piece
    {
        public King(PlayerColors iColor, Position iPosition) : base(Types.KING, iColor, iPosition)
        {

        }
    }
}
