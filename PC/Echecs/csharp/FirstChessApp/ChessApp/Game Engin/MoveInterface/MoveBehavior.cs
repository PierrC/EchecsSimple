using ChessAppGDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    interface MoveBehavior
    {
        List<BoardPosition> GetPossibleMoves(ChessBoard cb, BoardPosition bp);
    }
}
