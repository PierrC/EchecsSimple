using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessEngine
{
    public class Piece
    {
        private Boolean IsBlack_;
        private Boolean HasMoved_;
        protected PieceSteps Steps_;
        private List<Position> PossibleNewPositions_;

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

        public Types Type { get; }
        public Image Image { get; }
        public Position Position { get; set; }
        

        public bool IsBlack { get => IsBlack_; }
        public PieceSteps Steps { get => Steps_; set => Steps_ = value; }
        public bool HasMoved { get => HasMoved_; set => HasMoved_ = value; }
        public List<Position> PossibleNewPositions { get => PossibleNewPositions_; }

        public Image GetImage()
        {
            return Image;
        }


        public Piece(Types iType, PlayerColors iColor, Position iPosition)
        {
            Type = iType;
            IsBlack_ = iColor == PlayerColors.BLACK ? true : false;
            HasMoved_ = false;
            Position = new Position(iPosition.Column, iPosition.Row);
            this.Image = SetImage();
            Steps_ = null;
        }

        public void UpdatePossiblePositions(Chessboard iBoard)
        {
            PossibleNewPositions_ = null;

            List<Position> PosPos = new List<Position>();
            Position currentPos = this.Position;
            int maxNumSteps = this.Steps.Multiple ? 7 : 1;
            foreach (Step step in this.Steps.Steps)
            {
                Boolean blocked = false;
                for (int i = 0; i < maxNumSteps && !blocked; i++)
                {
                    if (step.FirstMoveOnly && this.HasMoved)
                        break;
                    Position stepPosition = currentPos.GetPositionAfterStep(i + 1, step);
                    if (stepPosition.IsValid)
                    {
                        Square stepSquare = iBoard.GetSquare(stepPosition);
                        if (stepSquare != null)
                        {
                            Piece stepPiece = stepSquare.Piece;
                            if (stepPiece != null)
                            {
                                if (stepPiece.IsBlack == this.IsBlack)
                                {
                                    // Same Color it block the Piece to move any further with that step
                                    // We need to exit the loop
                                    blocked = true;
                                }
                                else
                                {
                                    // Yummy it's one of the other player Piece :)
                                    PosPos.Add(stepPosition);
                                    blocked = true;
                                }
                            }
                            else
                            {
                                // No Piece on the new Position Good... except if it's a cath move only
                                if (!step.CatchMoveOnly)
                                    PosPos.Add(stepPosition);
                            }
                        }
                    }
                }
            }
            PossibleNewPositions_ = PosPos;
        }

        private Image SetImage()
        {
            if (this.IsBlack)
            {
                if (this.Type == Piece.Types.PAWN)
                {
                    return new Bitmap(Resources.blackPawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Resources.blackRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Resources.blackKinght);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Resources.blackBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Resources.blackQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Resources.blackKing);
                }
            }
            else
            {
                if (Type.Equals(Types.PAWN))
                {
                    return new Bitmap(Resources.whitePawn);
                }
                else if (Type.Equals(Types.ROOK))
                {
                    return new Bitmap(Resources.whiteRook);
                }
                else if (Type.Equals(Types.KNIGHT))
                {
                    return new Bitmap(Resources.whiteKnight);
                }
                else if (Type.Equals(Types.BISHOP))
                {
                    return new Bitmap(Resources.whiteBishop);
                }
                else if (Type.Equals(Types.QUEEN))
                {
                    return new Bitmap(Resources.whiteQueen);
                }
                else if (Type.Equals(Types.KING))
                {
                    return new Bitmap(Resources.whiteKing);
                }
            }
            return null;
        }

    }
}
