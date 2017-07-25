using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    public class BoardPosition
    {
        public BoardPosition()
        {
            Invalid();
        }

        public BoardPosition(int ax, int ay)
        {
            this.X = ax;
            this.Y = ay;
        }

        public int X;
        public int Y;
        

        public Boolean IsValid()
        {
            if ((this.X >= 0) && (this.X < 8) && (this.Y >= 0) && (this.Y < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.X = -2;
            this.Y = -1;
        }
        

        public override String ToString()
        {
            switch (X)
            {
                case 0: return "[A," + (8 - Y) + "]";
                case 1: return "[B," + (8 - Y) + "]";
                case 2: return "[C," + (8 - Y) + "]";
                case 3: return "[D," + (8 - Y) + "]";
                case 4: return "[E," + (8 - Y) + "]";
                case 5: return "[F," + (8 - Y) + "]";
                case 6: return "[G," + (8 - Y) + "]";
                case 7: return "[H," + (8 - Y) + "]";
                default: return "0";
            }
        }


    }
}
