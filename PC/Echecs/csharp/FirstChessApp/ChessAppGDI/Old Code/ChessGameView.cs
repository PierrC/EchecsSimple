using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI
{
    class ChessGameView
    {
        ChessGame game;
        ArrayList BoardViewPiece;
        Boolean[,] BoardHasPiece;

        BoardPosition discard = new BoardPosition(-2, -2);


        ChessGameView()
        {
            game = new ChessGame( Piece.Color.WHITE);
            BoardViewPiece = new ArrayList();
            BoardHasPiece = new Boolean[8, 8];

            MakeViewPieceList();
        }

        private void MakeViewPieceList()
        {
            Piece[,] board = game.GetBoardPiece();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!board[i, j].Equals(null))
                    {
                        BoardViewPiece.Add(new Piece(board[i, j], new BoardPosition(i, j)));
                        BoardHasPiece[i, j] = true;
                    }
                }
            }
        }

        public void movePiece(BoardPosition start, BoardPosition end)
        {
            Piece[,] board = game.GetBoardPiece();
            PieceView movingPiece = new PieceView(new Piece(Piece.PieceType.PAWN, Piece.Color.WHITE), discard);
            PieceView leavingPiece = new PieceView(new Piece(Piece.PieceType.PAWN, Piece.Color.WHITE), discard);

            if( !BoardHasPiece[end.X, end.Y])
            {
                addPiece(board[start.X, start.Y], end);
            }

            /*
            if ( BoardHasPiece[start.X, start.Y])
            {

                if ( BoardHasPiece[end.X, end.Y] && board[end.X, end.Y].getColor().Equals( ChessGame.OtherColor(board[start.X, start.Y].getColor())))
                {
                    BoardPosition position1 = new BoardPosition(start.X, start.Y);
                    BoardPosition position2 = new BoardPosition(end.X, end.Y);
                    foreach(PieceView pView in BoardViewPiece)
                    {
                            if (pView.GetPosition().Equals(position1))
                            {
                                movingPiece = pView;
                            }
                            if (pView.GetPosition().Equals(position2))
                            {
                                leavingPiece = pView;
                            }
                    }

                    if (!leavingPiece.GetPosition().Equals(discard))
                    {
                        leavingPiece.SetPosition(discard);
                    }

                    if (!movingPiece.GetPosition().Equals(discard))
                    {
                        leavingPiece.SetPosition(discard);
                        movingPiece.SetPosition(position2);
                        BoardHasPiece[position1.X, position1.Y] = false;

                    }
                }
            }
            */


        }

        public void addPiece(Piece pPiece, BoardPosition pPosition)
        {
            if(BoardHasPiece[pPosition.X, pPosition.Y] == true)
            {
                removePiece(pPosition);
            }
            BoardHasPiece[pPosition.X, pPosition.Y] = true;
            game.GetBoardPiece()[pPosition.X, pPosition.Y] = pPiece;
        }

        public void removePiece(BoardPosition pPosition)
        {

            if(BoardHasPiece[pPosition.X, pPosition.Y])
            {
                game.GetBoardPiece()[pPosition.X, pPosition.Y] = null;
            }
        }

        public void removePiece(Piece piece)
        {
            foreach (PieceView pView in BoardViewPiece)
            {
                if (pView.GetPiece().Equals(piece))
                {
                    pView.SetPosition(discard);
                    BoardHasPiece[pView.GetPosition().X, pView.GetPosition().Y] = false;
                }
            }
        }


    }
}
