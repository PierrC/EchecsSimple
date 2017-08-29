using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    public class PromotionManipulator
    {
        Piece.PieceType aPromotionType;
        
        public PromotionManipulator()
        {
            aPromotionType = Piece.PieceType.QUEEN;
        }

        public void ReplacePawn(BoardPosition bp, ChessBoard aBoard)
        {
            Piece replacement;
            if (bp.Y == 0)
            {
                replacement = new Piece(aPromotionType, Piece.Color.WHITE);
            }
            else
            {
                replacement = new Piece(aPromotionType, Piece.Color.BLACK);
            }
            aBoard.GetBoard()[bp.X, bp.Y].SetPiece(replacement);

        }

        public void SetPromotionPiece(int i)
        {
            switch (i)
            {
                case 0:
                    aPromotionType = Piece.PieceType.BISHOP;
                    break;
                case 1:
                    aPromotionType = Piece.PieceType.KNIGHT;
                    break;
                case 2:
                    aPromotionType = Piece.PieceType.QUEEN;
                    break;
                case 3:
                    aPromotionType = Piece.PieceType.ROOK;
                    break;
                default:
                    aPromotionType = Piece.PieceType.QUEEN;
                    break;
            }
        }
    }
}
