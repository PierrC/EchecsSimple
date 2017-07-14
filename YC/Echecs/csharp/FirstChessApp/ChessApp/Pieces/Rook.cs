using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class Rook : Piece
    {

        private Players Player;
        private Colors Color;
        

        public Rook(Players p, Colors c)
        {
            Player = p;
            Color = c;
        }
    }
}
