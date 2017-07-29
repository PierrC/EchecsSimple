using ChessAppGDI.New_Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessAppGDI
{
    public partial class ChessApp : Form
    {
        int i = PositionAndPixels.boardPanel_x ;
        Pen mainPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Font myFont = new Font("Times New Roman", 16);


        ChessGame chessGame;
        Piece ConvertPiece = new Piece(Piece.Types.PAWN, Piece.Colors.WHITE);


        int mouse_x = 0, mouse_y = 0;
        ArrayList listPiece = new ArrayList();
        
        

        public ChessApp()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 600);

            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(boardPanel);
            chessGame =  new ChessGame();
            
        }
        
        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            PositionAndPixels.boardPanel_x = boardPanel.Width;
            PositionAndPixels.boardPanel_y = boardPanel.Height;
            PositionAndPixels.Update();

            g = e.Graphics;
            UpdateBoard();
        }

        private void UpdateBoard()
        {
            g.Clear(Color.White);
            chessGame.DrawBoard(g);
        }
        

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        

        private void boardPanel_MouseMove_1(object sender, MouseEventArgs e)
        {

            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void boardPanel_MouseClick(object sender, MouseEventArgs e)
        {

            
            Point mousePoint = new Point(mouse_x, mouse_y);
            BoardPosition bp = PositionAndPixels.PixelsToBoardPosition(mousePoint);
            
            if (e.Button == MouseButtons.Right)
            {
                chessGame.DiscardPiece();
                ChessMechanics.PrintBoardView(chessGame.getChessBoardView());
            }
            else
            {
                chessGame.MovePiece(bp);
            }

            selectedPieceTextBox.Text = chessGame.PrintPiece();
            
            Refresh();
        }

        private void choseButton_Click(object sender, EventArgs e)
        {

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                if (checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(itemChecked)))
                {
                    checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(itemChecked));
                    int i = checkedListBox1.Items.IndexOf(itemChecked);
                    switch (i)
                    {
                        case 0:
                            chessGame.SetConvertPiece(new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE));
                            break;
                        case 1:
                            chessGame.SetConvertPiece(new Piece(Piece.Types.KNIGHT, Piece.Colors.WHITE));
                            break;
                        case 2:
                            chessGame.SetConvertPiece(new Piece(Piece.Types.QUEEN, Piece.Colors.WHITE));
                            break;
                        case 3:
                            chessGame.SetConvertPiece(new Piece(Piece.Types.QUEEN, Piece.Colors.WHITE));
                            break;
                        default:
                            chessGame.SetConvertPiece(new Piece(Piece.Types.BISHOP, Piece.Colors.WHITE));
                            break;
                    }
                }

            }
            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        

    }


}
