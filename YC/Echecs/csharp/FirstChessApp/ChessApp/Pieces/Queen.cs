using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class Queen : Piece
    {


        private Players Player;
        private Colors Color;
        

        public Queen(Players p, Colors c)
        {
            Player = p;
            Color = c;
        }
    }
}
