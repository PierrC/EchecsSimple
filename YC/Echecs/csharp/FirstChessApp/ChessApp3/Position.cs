using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class Position
    {
        private int Row_;
        private int Column_;

        public Position()
        {
            Invalid();
        }

        public Position(int iRow, int iColumn)
        {
            this.Row = iRow;
            this.Column = iColumn;
        }

        public int Row
        {
            get => Row_;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                Row_ = value;
            }

        }
        public int Column
        {
            get => Column_;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                Column_ = value;
            }
        }

        public Boolean IsValid()
        {
            if ((this.Row >= 0) && (this.Row < 8) && (this.Row >= 0) && (this.Row < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.Row = -1;
            this.Column = -1;
        }
    }

}
