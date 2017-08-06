using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class ChessGame
    {
        private Chessboard Board_;
        private PieceSet BlackPieces_;
        private PieceSet WhitePieces_;

        private Piece.PlayerColors CurrentPlayer_;
        private Piece SelectedPiece_;


        public Chessboard Board { get => Board_; }
        public PieceSet BlackPieces { get => BlackPieces_; }
        public PieceSet WhitePieces { get => WhitePieces_; }
        public Piece SelectedPiece { get => SelectedPiece_; set => SelectedPiece_ = value; }

        public event EventHandler Changed;

        public ChessGame()
        {
            Board_ = new Chessboard();
            BlackPieces_ = new PieceSet(Piece.PlayerColors.BLACK);
            WhitePieces_ = new PieceSet(Piece.PlayerColors.WHITE);
            SetUpBoard(Board, WhitePieces);
            SetUpBoard(Board, BlackPieces);
            CurrentPlayer_ = Piece.PlayerColors.WHITE;
            SelectedPiece = null;
            BlackPieces.UpdatePossiblePositions(Board);
            WhitePieces.UpdatePossiblePositions(Board);
        }

        protected virtual void Notifychange()
        {
            if (Changed != null)
                Changed(this, new EventArgs());
        }

        public Boolean IsCurrentPlayerBlack()
        {
            return CurrentPlayer_ == Piece.PlayerColors.BLACK;
        }

        public void SwapCurrentPlayer()
        {
            CurrentPlayer_ = IsCurrentPlayerBlack() ? Piece.PlayerColors.WHITE : Piece.PlayerColors.BLACK;
        }

        public void OnSquareSelection(Position SelectedSquarePosition)
        {
            Square SelectedSquare = Board.GetSquare(SelectedSquarePosition);
            if (SelectedSquare != null)
            {
                if ((SelectedPiece != null) && (SelectedPiece.PossibleNewPositions != null))
                {
                    foreach (Position P in SelectedPiece.PossibleNewPositions)
                    {
                        if (P.Equals(SelectedSquarePosition))
                        {
                            // move if valid
                            movePiece(Board, SelectedPiece, SelectedSquarePosition);
                            SwapCurrentPlayer();
                            BlackPieces.UpdatePossiblePositions(Board);
                            WhitePieces.UpdatePossiblePositions(Board);

                            SelectedPiece = null;
                            Notifychange();
                            return;
                        }
                    }
                }


                Piece SPiece = SelectedSquare.Piece;
                if (SPiece != null)
                {
                    if (SPiece.IsBlack == IsCurrentPlayerBlack())
                    {
                        SelectedPiece = SPiece;
                        //SelectedPiece.UpdatePossiblePositions(Board);
                        Notifychange();
                    }
                    else
                    {
                        Console.WriteLine("You select a Piece from the side");
                        SelectedPiece = null;
                        Notifychange();
                    }
                }
            }
        }

        private void movePiece(Chessboard iBoard, Piece iPiece, Position newPosition)
        {
            if (!newPosition.IsValid)
                return;

            if ((iPiece != null) && (iPiece.Position.IsValid))
            {
                iBoard.GetSquare(iPiece.Position).RemovePiece();
            }

            //TODO instanciate a move and add in in the move history
            if (iBoard.GetSquare(newPosition).HasPiece())
            {
                // Kill first .... 
                iBoard.GetSquare(newPosition).Piece.Position.Column = -1;
            }
            // ....Then move
            iBoard.GetSquare(newPosition).PutPiece(iPiece);
            iPiece.Position = newPosition;
            iPiece.HasMoved = true;
        }

        private List<Position> GetPossiblePositions(Chessboard iBoard, Piece iPiece)
        {
            List<Position> PosPos = new List<Position>();
            Position currentPos = iPiece.Position;
            int maxNumSteps = iPiece.Steps.Multiple ? 7 : 1;
            foreach (Step step in iPiece.Steps.Steps)
            {
                Boolean blocked = false;
                for (int i=0; i<maxNumSteps && !blocked; i++)
                {
                    if (step.FirstMoveOnly && iPiece.HasMoved)
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
                                if (stepPiece.IsBlack == iPiece.IsBlack)
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
            return PosPos;
        }

        private void SetUpBoard(Chessboard iBoard, PieceSet iPieces)
        {
            foreach (Piece P in iPieces)
            {
                Square square = iBoard.GetSquare(P.Position);
                square.Piece = P;
            }
        }
    }
}
