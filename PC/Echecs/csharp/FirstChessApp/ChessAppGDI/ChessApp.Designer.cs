namespace ChessAppGDI
{
    partial class ChessApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1WhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedPieceTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.boardPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.startGameToolStripMenuItem.Text = "Restart";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1WhiteToolStripMenuItem,
            this.player1BlackToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // player1WhiteToolStripMenuItem
            // 
            this.player1WhiteToolStripMenuItem.Name = "player1WhiteToolStripMenuItem";
            this.player1WhiteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.player1WhiteToolStripMenuItem.Text = "Player 1 : White";
            this.player1WhiteToolStripMenuItem.Click += new System.EventHandler(this.player1WhiteToolStripMenuItem_Click);
            // 
            // player1BlackToolStripMenuItem
            // 
            this.player1BlackToolStripMenuItem.Name = "player1BlackToolStripMenuItem";
            this.player1BlackToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.player1BlackToolStripMenuItem.Text = "Player 1 : Black";
            this.player1BlackToolStripMenuItem.Click += new System.EventHandler(this.player1BlackToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.75768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.24232F));
            this.tableLayoutPanel1.Controls.Add(this.boardPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 438);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // boardPanel
            // 
            this.boardPanel.Controls.Add(this.panel1);
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPanel.Location = new System.Drawing.Point(3, 3);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(423, 432);
            this.boardPanel.TabIndex = 0;
            this.boardPanel.Click += new System.EventHandler(this.boardPanel_Click);
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            this.boardPanel.DoubleClick += new System.EventHandler(this.boardPanel_DoubleClick);
            this.boardPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedPieceTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(432, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 432);
            this.panel2.TabIndex = 1;
            // 
            // selectedPieceTextBox
            // 
            this.selectedPieceTextBox.Location = new System.Drawing.Point(3, 3);
            this.selectedPieceTextBox.Name = "selectedPieceTextBox";
            this.selectedPieceTextBox.Size = new System.Drawing.Size(112, 20);
            this.selectedPieceTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ChessAppGDI.Properties.Resources.whiteRook;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(363, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 60);
            this.panel1.TabIndex = 1;
            // 
            // ChessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(553, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChessApp";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.boardPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1WhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1BlackToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox selectedPieceTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}

