using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
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
        public BoardPosition Position { get; }

        public bool IsBlack { get => IsDark_; }

        public Square(Colors iColor, BoardPosition iPosition)
        {
            IsDark_ = iColor == Colors.DARK ? true : false;
            Position = new BoardPosition(iPosition.Row, iPosition.Column);
            Piece_ = null;
        }

        Boolean HasPiece()
        {
            return Piece_ != null;
        }

        public void PutPiece(Piece iPiece)
        {
            Piece_ = iPiece;
        }

        public void PemovePiece()
        {
            Piece_ = null;
        }
    }
}
