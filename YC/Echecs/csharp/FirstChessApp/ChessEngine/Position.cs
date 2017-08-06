using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Position
    {
        private int Column_;
        private int Row_;

        public Position()
        {
            Invalid();
        }

        public Position(int iColumn, int iRow)
        {
            this.Column = iColumn;
            this.Row = iRow;
        }


        public int Column
        {
            get => Column_;
            set
            {
                if ((value < 0) && (value >= 8))
                    Invalid();
                else
                    Column_ = value;
            }
        }

        public int Row
        {
            get => Row_;
            set
            {
                if ((value < 0) && (value >= 8))
                    Invalid();
                else
                    Row_ = value;
            }

        }

        public Boolean IsValid
        {
            get
            {
                if ((this.Column_ >= 0) && (this.Column_ < 8) && (this.Row >= 0) && (this.Row < 8))
                    return true;
                return false;
            }
        }

        public void Invalid()
        {
            this.Row = -1;
            this.Column = -1;
        }

        public bool Equals(Position pos)
        {
            // If parameter is null return false.
            if (pos == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (Row == pos.Row) && (Column == pos.Column);
        }

        public override String ToString()
        {
            char scol = 'A';
            scol += Convert.ToChar(Column);
            int row1 = Row + 1;
            return "[" + scol.ToString() + ", " + row1.ToString() + "]";
        }

        public Position GetPositionAfterStep(int numStep, Step step)
        {
            return new Position(this.Column + numStep * step.DeltaColumn, this.Row + numStep * step.DeltaRow);
        }
    }

}
