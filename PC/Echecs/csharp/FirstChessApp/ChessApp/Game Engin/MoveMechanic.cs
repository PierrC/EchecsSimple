using ChessApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Game_Engin
{
    public static class MoveMechanic
    {
        public static List<BoardPosition> GetAvaiableMoves(BoardPosition bp, ChessBoard aBoard)
        {
            if (!aBoard.GetBoard()[bp.X, bp.Y].HasPiece())
            {
                return null;
            }
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();

            switch (p.GetPieceType())
            {
                case (Piece.PieceType.PAWN): return GetPawnMoves(bp, aBoard);
                case (Piece.PieceType.ROOK): return GetRookMoves(bp, aBoard);
                case (Piece.PieceType.KNIGHT): return GetKnightMoves(bp, aBoard);
                case (Piece.PieceType.BISHOP): return GetBishopMoves(bp, aBoard);
                case (Piece.PieceType.QUEEN): return GetQueenMoves(bp, aBoard);
                case (Piece.PieceType.KING): return GetKingMoves(bp, aBoard);
                default: return null;
            }

        }

        private static List<BoardPosition> GetRookMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();

            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, 0, 1, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, 0, -1, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, 1, 0, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, -1, 0, p, aBoard));

            return boardPositionList;
        }

        private static List<BoardPosition> GetPawnMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;
            // Right now white is assumed to be at the bottom of the board 
            // TODO: find a way to make sure the color is not the factor
            if (p.GetColor() == Piece.Color.BLACK)
            {
                if (j > 0)
                {
                    // Double square
                    if (j > 1)
                    {
                        if (!(aBoard.GetBoard()[i, j].GetPiece().GetHasMoved())
                            && !aBoard.GetBoard()[i, j - 2].HasPiece()
                            && !aBoard.GetBoard()[i, j - 1].HasPiece())
                        {
                            boardPositionList.Add(new BoardPosition(i, j - 2));
                        }
                    }
                    // front square
                    j--;
                    if (!aBoard.GetBoard()[i, j].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    if (i > 0)
                    {
                        i--;
                        if (aBoard.GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(aBoard.GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                    i = bp.X;
                    if (i < 7)
                    {
                        i++;
                        if (aBoard.GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(aBoard.GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                }
                i = bp.X;
                j = bp.Y;
                if (j == 3)
                {
                    if (i > 0)
                    {
                        if (aBoard.GetBoard()[i - 1, j].HasPiece())
                        {
                            if (aBoard.GetBoard()[i - 1, j].GetPiece().GetJumpedLastTurn())
                            {
                                boardPositionList.Add(new BoardPosition(i - 1, j - 1));
                            }
                        }
                    }
                    if (i < 7)
                    {
                        if (aBoard.GetBoard()[i + 1, j].HasPiece())
                        {
                            if (aBoard.GetBoard()[i + 1, j].GetPiece().GetJumpedLastTurn())
                            {
                                boardPositionList.Add(new BoardPosition(i + 1, j - 1));
                            }
                        }
                    }
                }
            }
            else
            {
                if (j < 7)
                {
                    if (j < 6)
                    {
                        if (!(aBoard.GetBoard()[i, j].GetPiece().GetHasMoved())
                            && !aBoard.GetBoard()[i, j + 2].HasPiece())
                        {
                            boardPositionList.Add(new BoardPosition(i, j + 2));
                        }
                    }

                    j++;
                    if (!aBoard.GetBoard()[i, j].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i, j));
                    }
                    i--;
                    if (i >= 0)
                    {
                        if (aBoard.GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(aBoard.GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                    i = bp.X;
                    if (i < 7)
                    {
                        i++;
                        if (aBoard.GetBoard()[i, j].HasPiece())
                        {
                            if (!p.IsSameColor(aBoard.GetBoard()[i, j].GetPiece()))
                            {
                                boardPositionList.Add(new BoardPosition(i, j));
                            }
                        }
                    }
                }
                i = bp.X;
                j = bp.Y;
                if (j == 4)
                {
                    if (i > 0)
                    {
                        if (aBoard.GetBoard()[i - 1, j].HasPiece())
                        {
                            if (aBoard.GetBoard()[i - 1, j].GetPiece().GetJumpedLastTurn())
                            {
                                boardPositionList.Add(new BoardPosition(i - 1, j + 1));
                            }
                        }
                    }
                    if (i < 7)
                    {
                        if (aBoard.GetBoard()[i + 1, j].HasPiece())
                        {
                            if (aBoard.GetBoard()[i + 1, j].GetPiece().GetJumpedLastTurn())
                            {
                                boardPositionList.Add(new BoardPosition(i + 1, j + 1));
                            }
                        }
                    }
                }
            }
            return boardPositionList;
        }

        private static List<BoardPosition> GetKingMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();

            int i = bp.X;
            int j = bp.Y;

            //  boardPositionList.AddRange(CheckCastling(bp, pChessBoard));
            ///////////////
            if (i >= 1)
            {
                if (j >= 1)
                {
                    if (!aBoard.GetBoard()[i - 1, j - 1].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i - 1, j - 1));
                    }
                    else
                    {
                        if (!p.IsSameColor(aBoard.GetBoard()[i - 1, j - 1].GetPiece()))
                        {
                            boardPositionList.Add(new BoardPosition(i - 1, j - 1));
                        }

                    }
                }

                if (!aBoard.GetBoard()[i - 1, j].HasPiece())
                {
                    boardPositionList.Add(new BoardPosition(i - 1, j));
                }

                if (j < 7)
                {
                    if (!aBoard.GetBoard()[i - 1, j + 1].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i - 1, j + 1));
                    }
                    else
                    {
                        if (!p.IsSameColor(aBoard.GetBoard()[i - 1, j + 1].GetPiece()))
                        {
                            boardPositionList.Add(new BoardPosition(i - 1, j + 1));
                        }

                    }
                }
            }
            if (j >= 1)
            {
                if (!aBoard.GetBoard()[i, j - 1].HasPiece())
                {
                    boardPositionList.Add(new BoardPosition(i, j - 1));
                }
                else
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i, j - 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j - 1));
                    }

                }
            }
            if (j <= 6)
            {
                if (!aBoard.GetBoard()[i, j + 1].HasPiece())
                {
                    boardPositionList.Add(new BoardPosition(i, j + 1));
                }
                else
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i, j + 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i, j + 1));
                    }

                }
            }
            if (i < 7)
            {
                if (j > 0)
                {
                    if (!aBoard.GetBoard()[i + 1, j - 1].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j - 1));
                    }
                    else if (!p.IsSameColor(aBoard.GetBoard()[i + 1, j - 1].GetPiece()))
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j - 1));
                     
                    }
                }

                if (!aBoard.GetBoard()[i + 1, j].HasPiece())
                {
                    boardPositionList.Add(new BoardPosition(i + 1, j));
                }

                if (j < 7)
                {
                    if (!aBoard.GetBoard()[i + 1, j + 1].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j + 1));
                    }
                    else
                    {
                        if (!p.IsSameColor(aBoard.GetBoard()[i + 1, j + 1].GetPiece()))
                        {
                            boardPositionList.Add(new BoardPosition(i + 1, j + 1));
                        }

                    }

                }

                if (j < 7)
                {
                    if (!aBoard.GetBoard()[i + 1, j + 1].HasPiece())
                    {
                        boardPositionList.Add(new BoardPosition(i + 1, j + 1));
                    }
                    else
                    {
                        if (!p.IsSameColor(aBoard.GetBoard()[i + 1, j + 1].GetPiece()))
                        {
                            boardPositionList.Add(new BoardPosition(i + 1, j + 1));
                        }

                    }
                }
            }
            return boardPositionList;
        }

        private static List<BoardPosition> GetQueenMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();
            boardPositionList.AddRange(GetRookMoves(bp, aBoard));
            boardPositionList.AddRange(GetBishopMoves(bp, aBoard));
            return boardPositionList;
        }

        private static List<BoardPosition> GetBishopMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, -1, -1, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, 1, -1, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, -1, 1, p, aBoard));
            boardPositionList.AddRange(CheckBoardPosition(bp.X, bp.Y, 1, 1, p, aBoard));

            return boardPositionList;
        }

        private static List<BoardPosition> GetKnightMoves(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();

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
                if (aBoard.GetBoard()[i - 2, j + 1].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i - 2, j + 1].GetPiece()))
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
                if (aBoard.GetBoard()[i - 1, j + 2].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i - 1, j + 2].GetPiece()))
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
                if (aBoard.GetBoard()[i + 1, j + 2].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i + 1, j + 2].GetPiece()))
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
                if (aBoard.GetBoard()[i + 2, j + 1].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i + 2, j + 1].GetPiece()))
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
                if (aBoard.GetBoard()[i + 2, j - 1].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i + 2, j - 1].GetPiece()))
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
                if (aBoard.GetBoard()[i + 1, j - 2].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i + 1, j - 2].GetPiece()))
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
                if (aBoard.GetBoard()[i - 1, j - 2].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i - 1, j - 2].GetPiece()))
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
                if (aBoard.GetBoard()[i - 2, j - 1].HasPiece())
                {
                    if (!p.IsSameColor(aBoard.GetBoard()[i - 2, j - 1].GetPiece()))
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

        private static List<BoardPosition> CheckCastling(BoardPosition bp, ChessBoard aBoard)
        {
            List<BoardPosition> boardPositionList = new List<BoardPosition>();
            boardPositionList.Add(bp);
            Piece p = aBoard.GetBoard()[bp.X, bp.Y].GetPiece();


            int i = bp.X;
            int j = bp.Y;
            if (p.GetColor() == Piece.Color.WHITE)
            {
                if (!p.GetHasMoved())
                {
                    if (aBoard.GetBoard()[0, 7].GetPiece() != null)
                    {
                        if (aBoard.GetBoard()[0, 7].GetPiece().GetPieceType() == Piece.PieceType.ROOK)
                        {
                            if (!aBoard.GetBoard()[0, 7].GetPiece().GetHasMoved())
                            {
                                if (!aBoard.GetBoard()[1, 7].HasPiece() &&
                                    !aBoard.GetBoard()[2, 7].HasPiece() &&
                                    !aBoard.GetBoard()[3, 7].HasPiece())
                                {
                                    if (!SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(0, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(1, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(2, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(3, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(5, 7), aBoard))
                                    {
                                        boardPositionList.Add(new BoardPosition(2, 7));

                                    }
                                }
                            }
                        }
                    }
                    if (aBoard.GetBoard()[7, 7].GetPiece() != null)
                    {
                        if (aBoard.GetBoard()[7, 7].GetPiece().GetPieceType() == Piece.PieceType.ROOK)
                        {
                            if (!aBoard.GetBoard()[7, 7].GetPiece().GetHasMoved())
                            {
                                if (!aBoard.GetBoard()[6, 7].HasPiece() &&
                                    !aBoard.GetBoard()[5, 7].HasPiece())
                                {
                                    if (!SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(4, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(5, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(6, 7), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(7, 7), aBoard))
                                    {
                                        boardPositionList.Add(new BoardPosition(6, 7));
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (p.GetColor() == Piece.Color.BLACK)
            {
                if (!p.GetHasMoved())
                {
                    if (aBoard.GetBoard()[0, 0].GetPiece() != null)
                    {
                        if (aBoard.GetBoard()[0, 0].GetPiece().GetPieceType() == Piece.PieceType.ROOK)
                        {
                            if (!aBoard.GetBoard()[0, 0].GetPiece().GetHasMoved())
                            {
                                if (!aBoard.GetBoard()[1, 0].HasPiece() &&
                                    !aBoard.GetBoard()[2, 0].HasPiece() &&
                                    !aBoard.GetBoard()[3, 0].HasPiece())
                                {
                                    if (!SquareIsThreatened(aBoard.GetBoard()[4, 0].GetPiece(), new BoardPosition(1, 0), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 0].GetPiece(), new BoardPosition(2, 0), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 0].GetPiece(), new BoardPosition(3, 0), aBoard))
                                    {

                                        boardPositionList.Add(new BoardPosition(2, 0));
                                    }
                                }
                            }
                        }
                    }
                    if (aBoard.GetBoard()[7, 0].GetPiece() != null)
                    {
                        if (aBoard.GetBoard()[7, 0].GetPiece().GetPieceType() == Piece.PieceType.ROOK)
                        {
                            if (!aBoard.GetBoard()[7, 0].GetPiece().GetHasMoved())
                            {
                                if (!aBoard.GetBoard()[6, 0].HasPiece() &&
                                    !aBoard.GetBoard()[5, 0].HasPiece())
                                {
                                    if (!SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(5, 0), aBoard)
                                        && !SquareIsThreatened(aBoard.GetBoard()[4, 7].GetPiece(), new BoardPosition(6, 0), aBoard))
                                    {
                                        boardPositionList.Add(new BoardPosition(6, 0));
                                    }
                                }
                            }
                        }
                    }
                }

            }

            return boardPositionList;
        }

        public static bool SquareIsThreatened(Piece pPiece, BoardPosition bp, ChessBoard aBoard)
        {
            Piece.Color pieceColor = pPiece.GetColor();
            List<BoardPosition> moveList;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (aBoard.GetBoard()[i, j].HasPiece())
                    {
                        if (!(pPiece.IsSameColor(aBoard.GetBoard()[i, j].GetPiece())))
                        {
                            if (aBoard.GetBoard()[i, j].GetPiece().GetPieceType() == Piece.PieceType.QUEEN)
                            {
                                moveList = GetAvaiableMoves(new BoardPosition(i, j), aBoard);
                                //  Console.WriteLine("Position: " + i + "," + j);
                                foreach (BoardPosition b in moveList)
                                {
                                    //  Console.Write(b.ToString() + " ");
                                    if (b.IsSamePosition(bp))
                                    {
                                        return true;
                                    }

                                }

                            }
                        }
                    }

                }
            }

            return false;
        }
        
        private static List<BoardPosition> CheckBoardPosition(int i, int j, int iChange, int jChange, Piece pPiece, ChessBoard aBoard)
        {
            i += iChange; j += jChange;
            List<BoardPosition> boardPositions = new List<BoardPosition>();
            while (i <= 7 && i >= 0 && j <= 7 && j >= 0)
            {
                Console.WriteLine("i:" + i + " j:" + j);
                if (aBoard.GetBoard()[i, j].HasPiece())
                {
                    if (!pPiece.IsSameColor(aBoard.GetBoard()[i, j].GetPiece()))
                    {
                        boardPositions.Add(new BoardPosition(i, j));
                    }
                    break;
                }
                else
                {
                    boardPositions.Add(new BoardPosition(i, j));
                }
                i += iChange; j += jChange;
            }
            for(int m = 0; m < boardPositions.Count; m++)
            {
            Console.Write(boardPositions[m] + ", ");

            }
            return boardPositions;
        }
    }
}
