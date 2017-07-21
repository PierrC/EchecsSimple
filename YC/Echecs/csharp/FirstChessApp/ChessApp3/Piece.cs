using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp3
{
    public class Position
    {
        private int i;
        private int j;

        public Position()
        {
            Invalid();
        }

        public Position(int ii, int ij)
        {
            this.I = ii;
            this.J = ij;
        }

        public int I
        {
            get => i;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                i = value;
            }
   
        }
        public int J
        {
            get => j;
            set
            {
                if ((value >= 0) && (value < 8))
                    Invalid();
                j = value;
            }
        }

        public Boolean IsValid()
        {
            if ((this.I >= 0) && (this.I < 8) && (this.I >= 0) && (this.I < 8))
                return true;
            return false;
        }

        public void Invalid()
        {
            this.I = -1;
            this.J = -1;
        }
    }

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

        public enum PlayerColors
        {
            BLACK,
            WHITE
        }

        Types Type { get; set; }
        PlayerColors PlayerColor { get; set; }
        Image aImage { get; set; }
        Position Position { get; set; }


        //public Point GetPoint()
        //{
        //    return aCoor;
        //}

        //public void SetPoint(Point pt)
        //{
        //    aCoor = pt;
        //}

        public Image GetImage()
        {
            return aImage;
        }

        public PlayerColors getColor()
        {
            return PlayerColor;
        }

        //public Piece(Types pType, PlayerColors pColor, Point pCoor)
        //{
        //    Type = pType;
        //    PlayerColor = pColor;
        //    aCoor = pCoor;
        //    aImage = SetImage();
        //}

        //public Piece(Types pType, PlayerColors pColor, int x, int y)
        //{
        //    Type = pType;
        //    aPlayer = pPlayer;
        //    PlayerColor = pColor;
        //    aCoor = new Point(x, y);
        //    aImage = SetImage();
        //}

        private Image SetImage()
        {
            if (PlayerColor.Equals(PlayerColors.BLACK))
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(Properties.Resources.blackPawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.blackRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.blackKinght);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.blackBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.blackQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Properties.Resources.blackKing);
                }
            }
            else
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(Properties.Resources.whitePawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Properties.Resources.whiteRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Properties.Resources.whiteKnight);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Properties.Resources.whiteBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Properties.Resources.whiteQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Properties.Resources.whiteKing);
                }
            }
            return null;
        }

    }
}
