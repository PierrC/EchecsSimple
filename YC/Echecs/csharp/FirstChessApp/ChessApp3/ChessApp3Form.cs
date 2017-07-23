using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessApp3
{
    public partial class ChessApp3Form : Form
    {

        private ChessGame Game_;
        private ChessGameView GameView_;

        public ChessGame Game { get => Game_;}
        public ChessGameView GameView { get => GameView_;}

        public ChessApp3Form()
        {
            InitializeComponent();

            InitGame();
        }

        private void InitGame()
        {
            Game_ = new ChessGame();
            GameView_ = new ChessGameView(Game);
            renderAreaControl1.GameView = this.GameView;

        }
    }
}
