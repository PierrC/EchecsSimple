using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class Rook : piece
    {

        private playerNumber Player;
        private color Color;
        

        public Rook(playerNumber p, color c)
        {
            Player = p;
            Color = c;
        }
    }
}
