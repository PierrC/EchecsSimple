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
            LIGHT
        }

        /// <summary>
        /// Only a getter here since it's a imutable property
        /// </summary>
        public Position Position { get; }

        public bool IsDark { get => IsDark_; }
        public Piece Piece { get => Piece_; set => Piece_ = value; }

        public Square(Colors iColor, Position iPosition)
        {
            IsDark_ = iColor == Colors.DARK ? true : false;
            Position = new Position(iPosition.Row, iPosition.Column);
            Piece_ = null;
        }

        public Boolean HasPiece()
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
