using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public static class ChessMechanics
    {
        public static List<BoardPosition> AvaiableMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            Piece aPiece;
            if (pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].HasPiece())
            {
                aPiece = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();

            }
            else
            {
                return boardPositionList;
            }

            if( aPiece.Type == Piece.Types.ROOK)
            {
                boardPositionList.AddRange(GetRookMoves(bp, pChessBoard));
            }
            else if(aPiece.Type == Piece.Types.KNIGHT)
            {
                boardPositionList.AddRange(GetKnightMoves(bp, pChessBoard));
            }
            else if (aPiece.Type == Piece.Types.BISHOP)
            {
                boardPositionList.AddRange(GetBishopMoves(bp, pChessBoard));
            }
            else if (aPiece.Type == Piece.Types.KING)
            {
                boardPositionList.AddRange(GetKingMoves(bp, pChessBoard));
            }
            else if (aPiece.Type == Piece.Types.QUEEN)
            {
                boardPositionList.AddRange(GetQueenMoves(bp, pChessBoard));
            }
            else if (aPiece.Type == Piece.Types.PAWN)
            {
                boardPositionList.AddRange(GetPawnMoves(bp, pChessBoard));
            }


            return boardPositionList;
        }
        
        private static List<BoardPosition> GetPawnMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;
            // Right now white is assumed to be at the bottom of the board 
            // TODO: find a way to make sure the color is not the factor
            // TODO: add the ability to double jump at the begining and the ability 
            // to change pawn into other piece when it reaches the other side of the board
            if ( p.Color == Piece.Colors.WHITE)
            {
                if(j > 0)
                {
                    j--;
                    if (!pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    if (i > 0)
                    {
                        i--;
                        if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                    i = bp.X;

                    
                    i++;
                    if (i < 7)
                    {
                        if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                    
                }


            }
            else
            {
                if (j < 7)
                {
                    j++;
                    if (!pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    i--;
                    if (i > 0)
                    {
                        if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                    i = bp.X;
                    i++;
                    if (i < 7)
                    {
                        if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                }
            }

            return boardPositionList;
        }

        private static List<BoardPosition> GetKingMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {

            return null;
        }

        private static List<BoardPosition> GetQueenMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();
            boardPositionList.AddRange(GetRookMoves(bp, pChessBoard));
            boardPositionList.AddRange(GetBishopMoves(bp, pChessBoard));
            return boardPositionList;
        }

        private static List<BoardPosition> GetBishopMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;
            while( i > 0 && j > 0)
            {
                i--;
                j--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
                
            }
            i = bp.X;
            j = bp.Y;
            while (i < 7 && j > 0)
            {
                i++;
                j--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            i = bp.X;
            j = bp.Y;
            while (i > 0 && j < 7)
            {
                i--;
                j++;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            i = bp.X;
            j = bp.Y;
            while (i < 7 && j < 7)
            {
                i++;
                j++;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }

            return boardPositionList;
        }

        private static List<BoardPosition> GetRookMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;
            // Up
            while (j < 7 )
            {
                j++;
                if(pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece() )
                {
                    if(!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            j = bp.X;
            i = bp.Y;
            while( j >= 1)
            {
                j--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            j = bp.X;
            i = bp.Y;
            while (i < 7)
            {
                i++;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            j = bp.X;
            i = bp.Y;
            while (i >= 1)
            {
                i--;
                if (pChessBoard.GetChessBoard().GetBoard()[i, j].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i, j].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i, j));
                }
            }
            j = bp.X;
            i = bp.Y;
            return boardPositionList;
        }

        private static List<BoardPosition> GetKnightMoves(BoardPosition bp, ChessBoardView pChessBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = pChessBoard.GetChessBoard().GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;
            /////////////////////////////////////////////////
            //
            //             8 o 1
            //           7   o   2 
            //           o o x o o
            //           6   o   3   
            //             5 o 4 
            //
            ///////////////////// 1 /////////////////////////
            if (i >= 2 && j <= 6)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i - 2, j + 1].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i - 2, j + 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i - 2, j + 1));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i - 2, j + 1));
                }
            }
            ///////////////////// 2 /////////////////////////
            if (i >= 1 && j <= 5)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i - 1, j + 2].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i - 1, j + 2].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i - 1, j + 2));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i - 1, j + 2));
                }
            }
            ///////////////////// 3 /////////////////////////
            if (i <= 6 && j <= 5)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i + 1, j + 2].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i + 1, j + 2].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j + 2));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i + 1, j + 2));
                }
            }
            ///////////////////// 4 /////////////////////////
            if (i <= 5 && j <= 6)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i + 2, j + 1].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i + 2, j + 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i + 2, j + 1));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i + 2, j + 1));
                }
            }
            ///////////////////// 5 /////////////////////////
            if (i <= 5 && j >= 1)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i + 2, j - 1].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i + 2, j - 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i + 2, j - 1));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i + 2, j - 1));
                }
            }
            ///////////////////// 6 /////////////////////////
            if (i <= 6 && j >= 2)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i + 1, j - 2].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i + 1, j - 2].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j - 2));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i + 1, j - 2));
                }
            }
            ///////////////////// 7 /////////////////////////
            if (i >= 1 && j >= 2)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i - 1, j - 2].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i - 1, j - 2].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i - 1, j - 2));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i - 1, j - 2));
                }
            }
            ///////////////////// 8 /////////////////////////
            if (i >= 2 && j >= 1)
            {
                if (pChessBoard.GetChessBoard().GetBoard()[i - 2, j - 1].HasPiece())
                {
                    if (!p.IsSameColor(pChessBoard.GetChessBoard().GetBoard()[i - 2, j - 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i - 2, j - 1));
                    }
                }
                else
                {
                    boardPositionList.Add(new BoardPosition(i - 2, j - 1));
                }
            }

            return boardPositionList;
        
        }

        

    }
}
