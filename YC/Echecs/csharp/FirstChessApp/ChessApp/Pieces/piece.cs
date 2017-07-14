using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    public class Piece
    {
        public enum Colors
        {
            WHITE,
            BLACK
        }
        public enum Players
        {
            PLAYER1,
            PLAYER2
        }


        //private Players Player;
        //private Colors Color;
        //private Coordinates Position;

        public Players Player { get => Player; }
        public Colors Color { get => Color; }
        public Coordinates Position { get => Position; set => Position = value; }

        public Colors returnColor()
        {
            return Color;
        }

        public Players GetPlayer()
        {
            return Player;
        }

        public Coordinates GetCoor()
        {
            return Position;
        }

        public void SetCoor(Coordinates pCoor)
        {
            Position = pCoor;
        }


    };
}
