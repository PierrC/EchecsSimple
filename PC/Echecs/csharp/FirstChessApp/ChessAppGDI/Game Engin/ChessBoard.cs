using ChessAppGDI.Game_Engin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAppGDI.New_Code
{
    public class ChessBoard
    {
        Square[,] board;

       // private BoardPosition[,] boardPositionArray = 


        public ChessBoard()
        {
            board = new Square[8, 8];
            bool Dark = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new Square(Dark);
                    Dark = !Dark;
                }
                Dark = !Dark;
            }
        }

        public void Restart()
        {
            // Player 1 is at the bottom
            for (int i = 0; i < 8; i++)
            {
                board[i, 6].SetPiece(new Piece(PieceType.Types.PAWN, Piece.Colors.WHITE));
            }
            board[0, 7].SetPiece(new Piece(PieceType.Types.ROOK, Piece.Colors.WHITE));
            board[7, 7].SetPiece(new Piece(PieceType.Types.ROOK, Piece.Colors.WHITE));
            board[1, 7].SetPiece(new Piece(PieceType.Types.KNIGHT, Piece.Colors.WHITE));
            board[6, 7].SetPiece(new Piece(PieceType.Types.KNIGHT, Piece.Colors.WHITE));
            board[2, 7].SetPiece(new Piece(PieceType.Types.BISHOP, Piece.Colors.WHITE));
            board[5, 7].SetPiece(new Piece(PieceType.Types.BISHOP, Piece.Colors.WHITE));
            board[3, 7].SetPiece(new Piece(PieceType.Types.QUEEN, Piece.Colors.WHITE));
            board[4, 7].SetPiece(new Piece(PieceType.Types.KING, Piece.Colors.WHITE));
            // Player 2 is at the top
            for (int i = 0; i < 8; i++)
            {
                board[i, 1].SetPiece(new Piece(PieceType.Types.PAWN, Piece.Colors.BLACK));
            }
            board[0, 0].SetPiece(new Piece(PieceType.Types.ROOK, Piece.Colors.BLACK));
            board[7, 0].SetPiece(new Piece(PieceType.Types.ROOK, Piece.Colors.BLACK));
            board[1, 0].SetPiece(new Piece(PieceType.Types.KNIGHT, Piece.Colors.BLACK));
            board[6, 0].SetPiece(new Piece(PieceType.Types.KNIGHT, Piece.Colors.BLACK));
            board[2, 0].SetPiece(new Piece(PieceType.Types.BISHOP, Piece.Colors.BLACK));
            board[5, 0].SetPiece(new Piece(PieceType.Types.BISHOP, Piece.Colors.BLACK));
            board[3, 0].SetPiece(new Piece(PieceType.Types.QUEEN, Piece.Colors.BLACK));
            board[4, 0].SetPiece(new Piece(PieceType.Types.KING, Piece.Colors.BLACK));
        }

        public Square[,] GetBoard()
        {
            return board;
        }

        public static Piece.Colors OtherColor(Piece.Colors pColor)
        {
            if (pColor.Equals(Piece.Colors.WHITE))
            {
                return Piece.Colors.BLACK;
            }
            else
            {
                return Piece.Colors.WHITE;
            }
        }

        private void removePiece(BoardPosition pPosition)
        {
            board[pPosition.X, pPosition.Y].RemovePiece();
        }

        private void setPiece(BoardPosition pPosition, Piece pPiece)
        {
            board[pPosition.X, pPosition.Y].SetPiece(pPiece);
        }

        public void movePiece(BoardPosition pStart, BoardPosition pEnd)
        {
            if (board[pStart.X, pStart.Y].HasPiece())
            {
                Piece transferPiece = board[pStart.X, pStart.Y].GetPiece();
                if (!transferPiece.GetHasMoved())
                {
                    transferPiece.hasMoved = true;
                }
                board[pEnd.X, pEnd.Y].SetPiece(transferPiece);
                board[pStart.X, pStart.Y].RemovePiece();
            }
        }
        
        public List<BoardPosition> GetAvaibleMoves(BoardPosition bp)
        {
            List<BoardPosition> moves = new List<BoardPosition>();
            MoveSet moveSets = board[bp.X, bp.Y].GetPiece().pieceType.GetMoveSet();

            BoardPosition positionList = new BoardPosition();
            positionList = bp;
            BoardPosition currentPosition;
            Piece p = board[bp.X, bp.Y].GetPiece();
            moves.Add(bp);
            currentPosition = positionList;
            foreach (Move m in moveSets.getMoves())
            {
                currentPosition = positionList;
                if (IsInParameters(currentPosition, m, p))
                {
                    currentPosition = new BoardPosition(currentPosition.X + m.DeltaRow, currentPosition.Y + m.DeltaColumn);
                    moves.Add(currentPosition);
                    if (moveSets.IsMultiple())
                    {
                        while (IsInParameters(currentPosition, m, p))
                        {
                            currentPosition = new BoardPosition(currentPosition.X + m.DeltaRow, currentPosition.Y + m.DeltaColumn);
                            moves.Add(currentPosition);
                        }
                    }
                }
            }
            return moves;
        }
        
        private bool IsInParameters(BoardPosition bp, Move m, Piece p)
        {
            
            // Piece p = board[bp.X, bp.Y].GetPiece();
            if(p == null)
            {
                Console.WriteLine("Piece is null. Position: " + bp.ToString());
                return false;
            }

            int row = m.DeltaRow;
            int column = m.DeltaColumn;
            if (p.color == Piece.Colors.BLACK)
            {
                if (bp.X + row > 7 || bp.X + row < 0)
                {
                    return false;
                }
                if (bp.Y + column > 7 || bp.Y + column < 0)
                {
                    return false;
                }
                if (board[bp.X + row, bp.Y + column].HasPiece())
                {
                    if (p.pieceType.type == PieceType.Types.PAWN)
                    {
                        if (bp.X == 0)
                        {
                            return false;
                        }
                    }
                    if (p.IsSameColor(board[bp.X + row, bp.Y + column].GetPiece()))
                    {
                        return false;
                    }
                }
                if (m.FirstMoveOnly && p.hasMoved)
                {
                    return false;
                }
                if (p.pieceType.type == PieceType.Types.PAWN)
                {
                    if (m.DeltaColumn == 1 && (m.DeltaRow == 1 || m.DeltaRow == -1))
                    {
                        if (!board[bp.X + row, bp.Y + column].HasPiece())
                        {
                            return false;
                        }
                    }
                }
            }
            if(p.color == Piece.Colors.WHITE)
            {
                if (bp.X + row > 7 || bp.X + row < 0)
                {
                    return false;
                }
                if (bp.Y + column > 7 || bp.Y + column < 0)
                {
                    return false;
                }
                if (board[bp.X + row, bp.Y + column].HasPiece())
                {
                    if (p.pieceType.type == PieceType.Types.PAWN)
                    {
                        if (bp.X == 0)
                        {
                            return false;
                        }
                    }
                    if (p.IsSameColor(board[bp.X + row, bp.Y + column].GetPiece()))
                    {
                        return false;
                    }
                }
                if (m.FirstMoveOnly && p.hasMoved)
                {
                    return false;
                }
                if (p.pieceType.type == PieceType.Types.PAWN)
                {
                    if (m.DeltaColumn == 1 && (m.DeltaRow == 1 || m.DeltaRow == -1))
                    {
                        if (!board[bp.X + row, bp.Y + column].HasPiece())
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }



    }
}
