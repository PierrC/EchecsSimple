using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessApp.Pieces;

namespace ChessApp
{
    public class Player
    {
        Piece.Colors aColor;
        Piece.Players aNumber;

        public Player(Piece.Colors pColor, Piece.Players pNumber)
        {
            this.aColor = pColor;
            this.aNumber = pNumber;

        }

        public Piece.Colors getColor()
        {
            return aColor;
        }
        public Piece.Players getPlayer()
        {
            return aNumber;
        }
    }
}
