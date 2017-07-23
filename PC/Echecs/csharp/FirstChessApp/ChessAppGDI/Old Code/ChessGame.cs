using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    public class ChessGame
    {
        // Boolean[,] BoardHasPiece = new Boolean[8,8];
        Piece[,] BoardPiece = new Piece[8,8];
        //  ArrayList ListPiece = new ArrayList();

        BoardPosition discardPoint = new BoardPosition(-2, -1);

        public ChessGame(Piece.Color pColor)
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i, 6] = new Piece(Piece.PieceType.PAWN, pColor);
            //    BoardHasPiece[i, 6] = true;
            //    ListPiece.Add(BoardPiece[i, 6]);
            }
            BoardPiece[0, 7] = new Piece(Piece.PieceType.ROOK, pColor);
            BoardPiece[7, 7] = new Piece(Piece.PieceType.ROOK,pColor);
            BoardPiece[1, 7] = new Piece(Piece.PieceType.KNIGHT, pColor);
            BoardPiece[6, 7] = new Piece(Piece.PieceType.KNIGHT,  pColor);
            BoardPiece[2, 7] = new Piece(Piece.PieceType.BISHOP,  pColor);
            BoardPiece[5, 7] = new Piece(Piece.PieceType.BISHOP, pColor);
            BoardPiece[3, 7] = new Piece(Piece.PieceType.QUEEN, pColor);
            BoardPiece[4, 7] = new Piece(Piece.PieceType.KING, pColor);
            /*
            ListPiece.Add(BoardPiece[0, 7]);
            ListPiece.Add(BoardPiece[1, 7]);
            ListPiece.Add(BoardPiece[2, 7]);
            ListPiece.Add(BoardPiece[3, 7]);
            ListPiece.Add(BoardPiece[4, 7]);
            ListPiece.Add(BoardPiece[5, 7]);
            ListPiece.Add(BoardPiece[6, 7]);
            ListPiece.Add(BoardPiece[7, 7]);
            
            BoardHasPiece[0, 7] = true;
            BoardHasPiece[1, 7] = true;
            BoardHasPiece[2, 7] = true;
            BoardHasPiece[3, 7] = true;
            BoardHasPiece[4, 7] = true;
            BoardHasPiece[5, 7] = true;
            BoardHasPiece[6, 7] = true;
            BoardHasPiece[7, 7] = true;
            */
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i, 1] = new Piece(Piece.PieceType.PAWN, OtherColor(pColor));
               // BoardHasPiece[i, 1] = true;
               // ListPiece.Add(BoardPiece[i, 1]);
            }

            BoardPiece[0, 0] = new Piece(Piece.PieceType.ROOK, OtherColor(pColor));
            BoardPiece[7, 0] = new Piece(Piece.PieceType.ROOK, OtherColor(pColor));
            BoardPiece[1, 0] = new Piece(Piece.PieceType.KNIGHT, OtherColor(pColor));
            BoardPiece[6, 0] = new Piece(Piece.PieceType.KNIGHT, OtherColor(pColor));
            BoardPiece[2, 0] = new Piece(Piece.PieceType.BISHOP, OtherColor(pColor));
            BoardPiece[5, 0] = new Piece(Piece.PieceType.BISHOP, OtherColor(pColor));
            BoardPiece[3, 0] = new Piece(Piece.PieceType.QUEEN, OtherColor(pColor));
            BoardPiece[4, 0] = new Piece(Piece.PieceType.KING, OtherColor(pColor));
            /*
            ListPiece.Add(BoardPiece[0, 0]);
            ListPiece.Add(BoardPiece[1, 0]);
            ListPiece.Add(BoardPiece[2, 0]);
            ListPiece.Add(BoardPiece[3, 0]);
            ListPiece.Add(BoardPiece[4, 0]);
            ListPiece.Add(BoardPiece[5, 0]);
            ListPiece.Add(BoardPiece[6, 0]);
            ListPiece.Add(BoardPiece[7, 0]);
            
            BoardHasPiece[0, 0] = true;
            BoardHasPiece[1, 0] = true;
            BoardHasPiece[2, 0] = true;
            BoardHasPiece[3, 0] = true;
            BoardHasPiece[4, 0] = true;
            BoardHasPiece[5, 0] = true;
            BoardHasPiece[6, 0] = true;
            BoardHasPiece[7, 0] = true;
            */
        }
       /*
        public Boolean[,] GetBoardHasPiece()
        {
            return BoardHasPiece;
        }
        */

        public Piece[,] GetBoardPiece()
        {
            return BoardPiece;
        }

        /*
        public void SetListPiece(Boolean[,] pBoardHasPiece)
        {
            BoardHasPiece = pBoardHasPiece;
        }


        public void SetBoardHasPiece(Piece[,] pBoardPiece)
        {
            BoardPiece = pBoardPiece;
        }
 
        /*
        public ArrayList GetListPiece()
        {
            return ListPiece;
        }
        */

        /*
        public void SetBoardPiece(ArrayList pListPiece)
        {
            ListPiece = pListPiece;
        }
        */

        /// Not sure where to put this
        public static Piece.Color OtherColor(Piece.Color pColor)
        {
            if (pColor.Equals(Piece.Color.WHITE))
            {
                return Piece.Color.BLACK;
            }
            else
            {
                return Piece.Color.WHITE;
            }
        }
        






        /*
        public Piece removePiece(BoardPosition pt)
        {
            if( BoardHasPiece[pt.X, pt.Y])
            {
                Piece p = BoardPiece[pt.X, pt.Y];
                p.SetPoint(discardPoint);
                BoardPiece[pt.X, pt.Y] = null;
                BoardHasPiece[pt.X, pt.Y] = false;
                return p;
            }
            else
            {
                return null;
            }
        }
        
        public void setPiece( Piece p, Point pt)
        {
            if (!BoardHasPiece[pt.X, pt.Y])
            {
                BoardPiece[pt.X, pt.Y] = p;
                p.SetPoint(pt);
                BoardHasPiece[pt.X, pt.Y] = true;
            }
            else if (BoardHasPiece[pt.X, pt.Y] && BoardPiece[pt.X, pt.Y].getColor().Equals(OtherColor(p.getColor()))) 
            {
                BoardPiece[pt.X, pt.Y].SetPoint(discardPoint);
                BoardPiece[pt.X, pt.Y] = p;
                p.SetPoint(pt);
            }
        }
        
        public void movePiece(Piece p, BoardPosition pt)
        {
            
        }
        */

    }
}


