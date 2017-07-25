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
            this.Row = ax;
            this.Column = ay;
        }

        public int Row;
        public int Column;
        

        public Boolean IsValid()
        {
            if ((this.Row >= 0) && (this.Row < 8) && (this.Column >= 0) && (this.Column < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.Row = -2;
            this.Column = -1;
        }
        

        public override String ToString()
        {
            switch (Row)
            {
                case 0: return "[A," + (8 - Column) + "]";
                case 1: return "[B," + (8 - Column) + "]";
                case 2: return "[C," + (8 - Column) + "]";
                case 3: return "[D," + (8 - Column) + "]";
                case 4: return "[E," + (8 - Column) + "]";
                case 5: return "[F," + (8 - Column) + "]";
                case 6: return "[G," + (8 - Column) + "]";
                case 7: return "[H," + (8 - Column) + "]";
                default: return "0";
            }
        }


    }
}
