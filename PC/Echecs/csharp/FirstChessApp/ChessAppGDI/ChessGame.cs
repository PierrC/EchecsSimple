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
        Boolean[,] BoardHasPiece = new Boolean[8,8];
        Piece[,] BoardPiece = new Piece[8,8];
        ArrayList listPiece = new ArrayList();
        public ChessGame(Piece.Color pColor)
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i, 6] = new Piece(Piece.PieceType.PAWN, Piece.Player.PLAYER1, pColor, new Point(i, 6));
                BoardHasPiece[i, 6] = true;
                listPiece.Add(BoardPiece[i, 6]);
            }
            BoardPiece[0, 7] = new Piece(Piece.PieceType.ROOK, Piece.Player.PLAYER1, pColor, new Point(0, 7));
            BoardPiece[7, 7] = new Piece(Piece.PieceType.ROOK, Piece.Player.PLAYER1, pColor, new Point(7, 7));
            BoardPiece[1, 7] = new Piece(Piece.PieceType.KNIGHT, Piece.Player.PLAYER1, pColor, new Point(1, 7));
            BoardPiece[6, 7] = new Piece(Piece.PieceType.KNIGHT, Piece.Player.PLAYER1, pColor, new Point(6, 7));
            BoardPiece[2, 7] = new Piece(Piece.PieceType.BISHOP, Piece.Player.PLAYER1, pColor, new Point(2, 7));
            BoardPiece[5, 7] = new Piece(Piece.PieceType.BISHOP, Piece.Player.PLAYER1, pColor, new Point(5, 7));
            BoardPiece[3, 7] = new Piece(Piece.PieceType.QUEEN, Piece.Player.PLAYER1, pColor, new Point(3, 7));
            BoardPiece[4, 7] = new Piece(Piece.PieceType.KING, Piece.Player.PLAYER1, pColor, new Point(4, 7));
            listPiece.Add(BoardPiece[0, 7]);
            listPiece.Add(BoardPiece[1, 7]);
            listPiece.Add(BoardPiece[2, 7]);
            listPiece.Add(BoardPiece[3, 7]);
            listPiece.Add(BoardPiece[4, 7]);
            listPiece.Add(BoardPiece[5, 7]);
            listPiece.Add(BoardPiece[6, 7]);
            listPiece.Add(BoardPiece[7, 7]);
            BoardHasPiece[0, 7] = true;
            BoardHasPiece[1, 7] = true;
            BoardHasPiece[2, 7] = true;
            BoardHasPiece[3, 7] = true;
            BoardHasPiece[4, 7] = true;
            BoardHasPiece[5, 7] = true;
            BoardHasPiece[6, 7] = true;
            BoardHasPiece[7, 7] = true;
            
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                BoardPiece[i, 1] = new Piece(Piece.PieceType.PAWN, Piece.Player.PLAYER1, OtherColor(pColor), new Point(i, 1));
                BoardHasPiece[i, 1] = true;
                listPiece.Add(BoardPiece[i, 1]);
            }
            BoardPiece[0, 0] = new Piece(Piece.PieceType.ROOK, Piece.Player.PLAYER2, OtherColor(pColor), new Point(0, 0));
            BoardPiece[7, 0] = new Piece(Piece.PieceType.ROOK, Piece.Player.PLAYER2, OtherColor(pColor), new Point(7, 0));
            BoardPiece[1, 0] = new Piece(Piece.PieceType.KNIGHT, Piece.Player.PLAYER2, OtherColor(pColor), new Point(1, 0));
            BoardPiece[6, 0] = new Piece(Piece.PieceType.KNIGHT, Piece.Player.PLAYER2, OtherColor(pColor), new Point(6, 0));
            BoardPiece[2, 0] = new Piece(Piece.PieceType.BISHOP, Piece.Player.PLAYER2, OtherColor(pColor), new Point(2, 0));
            BoardPiece[5, 0] = new Piece(Piece.PieceType.BISHOP, Piece.Player.PLAYER2, OtherColor(pColor), new Point(5, 0));
            BoardPiece[3, 0] = new Piece(Piece.PieceType.QUEEN, Piece.Player.PLAYER2, OtherColor(pColor), new Point(3, 0));
            BoardPiece[4, 0] = new Piece(Piece.PieceType.KING, Piece.Player.PLAYER2, OtherColor(pColor), new Point(4, 0));
            listPiece.Add(BoardPiece[0, 0]);
            listPiece.Add(BoardPiece[1, 0]);
            listPiece.Add(BoardPiece[2, 0]);
            listPiece.Add(BoardPiece[3, 0]);
            listPiece.Add(BoardPiece[4, 0]);
            listPiece.Add(BoardPiece[5, 0]);
            listPiece.Add(BoardPiece[6, 0]);
            listPiece.Add(BoardPiece[7, 0]);
            BoardHasPiece[0, 0] = true;
            BoardHasPiece[1, 0] = true;
            BoardHasPiece[2, 0] = true;
            BoardHasPiece[3, 0] = true;
            BoardHasPiece[4, 0] = true;
            BoardHasPiece[5, 0] = true;
            BoardHasPiece[6, 0] = true;
            BoardHasPiece[7, 0] = true;
            
        }
        
        public ArrayList getListPiece()
        {
            return listPiece;
        }

        public Boolean[,] getBoardHasPiece()
        {
            return BoardHasPiece;
        }

        public Piece[,] getBoardPiece()
        {
            return BoardPiece;
        }

        private static Piece.Color OtherColor(Piece.Color pColor)
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
        
        public void movePiece(Piece p, Point pt)
        {
            Piece aPiece = removePiece( p.GetPoint() );
            setPiece(aPiece, pt);
        }

        public Piece removePiece(Point pt)
        {
            if( BoardHasPiece[pt.X, pt.Y])
            {
                Piece p = BoardPiece[pt.X, pt.Y];
                p.SetPoint(new Point(0, 4));
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
            if( !BoardHasPiece[pt.X, pt.Y])
            {
                BoardPiece[pt.X, pt.Y] = p;
                p.SetPoint(pt);
                BoardHasPiece[pt.X, pt.Y] = true;
            }
        }









    }
}


