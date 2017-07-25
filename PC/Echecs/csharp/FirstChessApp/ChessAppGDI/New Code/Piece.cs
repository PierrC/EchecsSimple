using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class Piece
    {
        public enum Types
        {
            PAWN,
            ROOK,
            KNIGHT,
            BISHOP,
            QUEEN,
            KING
        }

        public enum Colors
        {
            BLACK,
            WHITE,
        }

        private Types type;
        private Colors color;
        private Boolean IsBlack_;

        public Types Type { get => type; }
        public Colors Color { get => color; }
        public bool IsBlack { get => IsBlack_; }
        public BoardPosition Position { get; set; }

        public Piece(Types iType, Colors iColor)
        {
            type = iType;
            color = iColor;
        }

        public Piece(Types iType, Colors iColor, BoardPosition iPosition)
        {
            type = iType;
            IsBlack_ = iColor == Colors.BLACK ? true : false;
            Position = new BoardPosition(iPosition.Row, iPosition.Column);
        }

        public override String ToString()
        {
            return Type.ToString();
        }

    }
}
