using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class Knight : Piece
    {

        private Players Player;
        private Colors Color;
        

        public Knight(Players p, Colors c)
        {
            Player = p;
            Color = c;
        }

    }
}
