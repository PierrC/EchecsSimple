using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessEngine;

namespace ChessApp3
{
    public partial class GameControl : UserControl
    {
        private ChessGame Game_;

        public GameControl()
        {
            InitializeComponent();
        }

        public ChessGame Game { get => Game_; set => Game_ = value; }

        public void GameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Redraw Game From notification.");
            if (sender is ChessGame)
                this.UpdateGUI();
        }

        private void UpdateGUI()
        {
            this.PlayerTextBox.Text = Game.IsCurrentPlayerBlack() ? "Black" : "White";
            if (Game.SelectedPiece != null)
                this.PieceTextBox.Text =
                    Game.SelectedPiece.ToString() +
                    " " +
                    Game.SelectedPiece.Position.ToString();
            else
                this.PieceTextBox.Text = "";
        }
    }
}
