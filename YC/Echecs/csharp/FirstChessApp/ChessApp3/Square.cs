using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class Square
    {
        private Boolean IsDark_;
        // Not sure that the Square needs to reference the Piece it is holding
        private Piece Piece_;

        public enum Colors
        {
            DARK,
            WHITE
        }

        /// <summary>
        /// Only a getter here since it's a imutable property
        /// </summary>
        Position Position { get; }

        public bool IsBlack { get => IsDark_; }

        public Square(Colors iColor, Position iPosition)
        {
            IsDark_ = iColor == Colors.DARK ? true : false;
            Position.Row = iPosition.Row;
            Position.Column = iPosition.Column;

            Piece_ = null;
        }

        Boolean HasPiece()
        {
            return Piece_ != null;
        }

        public void PutPiece( Piece iPiece)
        {
            Piece_ = iPiece;
        }

        public void PemovePiece()
        {
            Piece_ = null;
        }
    }
}
