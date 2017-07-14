using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class Queen : piece
    {


        private playerNumber Player;
        private color Color;
        

        public Queen(playerNumber p, color c)
        {
            Player = p;
            Color = c;
        }
    }
}
