namespace ChessApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.endProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMoveSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Turn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhiteMoves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlackMoves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.blackPawn8 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.blackPawn7 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.blackPawn6 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.blackPawn5 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.blackPawn4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.blackPawn3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.blackPawn2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.blackPawn1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.whitePawn8 = new System.Windows.Forms.Panel();
            this.whitePawn7 = new System.Windows.Forms.Panel();
            this.whitePawn6 = new System.Windows.Forms.Panel();
            this.whitePawn5 = new System.Windows.Forms.Panel();
            this.whitePawn4 = new System.Windows.Forms.Panel();
            this.whitePawn3 = new System.Windows.Forms.Panel();
            this.whitePawn2 = new System.Windows.Forms.Panel();
            this.whitePawn1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.blackRook1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.blackKnight1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.blackKnight2 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.blackRook2 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.boardPanel.SuspendLayout();
            this.blackPawn8.SuspendLayout();
            this.blackPawn7.SuspendLayout();
            this.blackPawn6.SuspendLayout();
            this.blackPawn5.SuspendLayout();
            this.blackPawn4.SuspendLayout();
            this.blackPawn3.SuspendLayout();
            this.blackPawn2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.blackPawn1.SuspendLayout();
            this.whitePawn1.SuspendLayout();
            this.blackRook1.SuspendLayout();
            this.blackKnight1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.blackKnight2.SuspendLayout();
            this.blackRook2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endProgramToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.saveMoveSheetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // endProgramToolStripMenuItem
            // 
            this.endProgramToolStripMenuItem.Name = "endProgramToolStripMenuItem";
            this.endProgramToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.endProgramToolStripMenuItem.Text = "End Program";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // saveMoveSheetToolStripMenuItem
            // 
            this.saveMoveSheetToolStripMenuItem.Name = "saveMoveSheetToolStripMenuItem";
            this.saveMoveSheetToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.saveMoveSheetToolStripMenuItem.Text = "Save Move Sheet";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(534, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 531);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turn,
            this.WhiteMoves,
            this.BlackMoves});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 531);
            this.dataGridView1.TabIndex = 1;
            // 
            // Turn
            // 
            this.Turn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Turn.HeaderText = "Turn";
            this.Turn.MinimumWidth = 2;
            this.Turn.Name = "Turn";
            // 
            // WhiteMoves
            // 
            this.WhiteMoves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WhiteMoves.HeaderText = "WhiteMoves";
            this.WhiteMoves.Name = "WhiteMoves";
            // 
            // BlackMoves
            // 
            this.BlackMoves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BlackMoves.HeaderText = "BlackMoves";
            this.BlackMoves.Name = "BlackMoves";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boardPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // boardPanel
            // 
            this.boardPanel.BackgroundImage = global::ChessApp.Properties.Resources.whiteBishop;
            this.boardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardPanel.Controls.Add(this.blackRook2);
            this.boardPanel.Controls.Add(this.blackKnight2);
            this.boardPanel.Controls.Add(this.blackKnight1);
            this.boardPanel.Controls.Add(this.blackRook1);
            this.boardPanel.Controls.Add(this.blackPawn8);
            this.boardPanel.Controls.Add(this.blackPawn7);
            this.boardPanel.Controls.Add(this.blackPawn6);
            this.boardPanel.Controls.Add(this.blackPawn5);
            this.boardPanel.Controls.Add(this.blackPawn4);
            this.boardPanel.Controls.Add(this.blackPawn3);
            this.boardPanel.Controls.Add(this.blackPawn2);
            this.boardPanel.Controls.Add(this.blackPawn1);
            this.boardPanel.Controls.Add(this.whitePawn8);
            this.boardPanel.Controls.Add(this.whitePawn7);
            this.boardPanel.Controls.Add(this.whitePawn6);
            this.boardPanel.Controls.Add(this.whitePawn5);
            this.boardPanel.Controls.Add(this.whitePawn4);
            this.boardPanel.Controls.Add(this.whitePawn3);
            this.boardPanel.Controls.Add(this.whitePawn2);
            this.boardPanel.Controls.Add(this.whitePawn1);
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPanel.Location = new System.Drawing.Point(3, 3);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(525, 531);
            this.boardPanel.TabIndex = 2;
            // 
            // blackPawn8
            // 
            this.blackPawn8.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn8.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn8.Controls.Add(this.panel19);
            this.blackPawn8.Location = new System.Drawing.Point(445, 81);
            this.blackPawn8.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn8.Name = "blackPawn8";
            this.blackPawn8.Size = new System.Drawing.Size(61, 61);
            this.blackPawn8.TabIndex = 5;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel19.Location = new System.Drawing.Point(0, 61);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(61, 61);
            this.panel19.TabIndex = 3;
            // 
            // blackPawn7
            // 
            this.blackPawn7.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn7.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn7.Controls.Add(this.panel17);
            this.blackPawn7.Location = new System.Drawing.Point(384, 81);
            this.blackPawn7.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn7.Name = "blackPawn7";
            this.blackPawn7.Size = new System.Drawing.Size(61, 61);
            this.blackPawn7.TabIndex = 5;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Location = new System.Drawing.Point(0, 61);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(61, 61);
            this.panel17.TabIndex = 3;
            // 
            // blackPawn6
            // 
            this.blackPawn6.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn6.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn6.Controls.Add(this.panel15);
            this.blackPawn6.Location = new System.Drawing.Point(323, 81);
            this.blackPawn6.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn6.Name = "blackPawn6";
            this.blackPawn6.Size = new System.Drawing.Size(61, 61);
            this.blackPawn6.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel15.Location = new System.Drawing.Point(0, 61);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(61, 61);
            this.panel15.TabIndex = 3;
            // 
            // blackPawn5
            // 
            this.blackPawn5.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn5.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn5.Controls.Add(this.panel13);
            this.blackPawn5.Location = new System.Drawing.Point(262, 81);
            this.blackPawn5.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn5.Name = "blackPawn5";
            this.blackPawn5.Size = new System.Drawing.Size(61, 61);
            this.blackPawn5.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel13.Location = new System.Drawing.Point(0, 61);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(61, 61);
            this.panel13.TabIndex = 3;
            // 
            // blackPawn4
            // 
            this.blackPawn4.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn4.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn4.Controls.Add(this.panel11);
            this.blackPawn4.Location = new System.Drawing.Point(201, 81);
            this.blackPawn4.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn4.Name = "blackPawn4";
            this.blackPawn4.Size = new System.Drawing.Size(61, 61);
            this.blackPawn4.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(0, 61);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(61, 61);
            this.panel11.TabIndex = 3;
            // 
            // blackPawn3
            // 
            this.blackPawn3.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn3.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn3.Controls.Add(this.panel9);
            this.blackPawn3.Location = new System.Drawing.Point(140, 81);
            this.blackPawn3.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn3.Name = "blackPawn3";
            this.blackPawn3.Size = new System.Drawing.Size(61, 61);
            this.blackPawn3.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(0, 61);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(61, 61);
            this.panel9.TabIndex = 3;
            // 
            // blackPawn2
            // 
            this.blackPawn2.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn2.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn2.Controls.Add(this.panel5);
            this.blackPawn2.Controls.Add(this.panel4);
            this.blackPawn2.Location = new System.Drawing.Point(79, 81);
            this.blackPawn2.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn2.Name = "blackPawn2";
            this.blackPawn2.Size = new System.Drawing.Size(61, 61);
            this.blackPawn2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(61, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 61);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(0, 61);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 61);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(61, 61);
            this.panel4.TabIndex = 3;
            // 
            // blackPawn1
            // 
            this.blackPawn1.BackColor = System.Drawing.Color.Transparent;
            this.blackPawn1.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.blackPawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackPawn1.Controls.Add(this.panel3);
            this.blackPawn1.Location = new System.Drawing.Point(18, 81);
            this.blackPawn1.Margin = new System.Windows.Forms.Padding(0);
            this.blackPawn1.Name = "blackPawn1";
            this.blackPawn1.Size = new System.Drawing.Size(61, 61);
            this.blackPawn1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 61);
            this.panel3.TabIndex = 3;
            // 
            // whitePawn8
            // 
            this.whitePawn8.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn8.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn8.Location = new System.Drawing.Point(445, 386);
            this.whitePawn8.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn8.Name = "whitePawn8";
            this.whitePawn8.Size = new System.Drawing.Size(61, 61);
            this.whitePawn8.TabIndex = 4;
            // 
            // whitePawn7
            // 
            this.whitePawn7.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn7.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn7.Location = new System.Drawing.Point(384, 386);
            this.whitePawn7.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn7.Name = "whitePawn7";
            this.whitePawn7.Size = new System.Drawing.Size(61, 61);
            this.whitePawn7.TabIndex = 4;
            // 
            // whitePawn6
            // 
            this.whitePawn6.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn6.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn6.Location = new System.Drawing.Point(323, 386);
            this.whitePawn6.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn6.Name = "whitePawn6";
            this.whitePawn6.Size = new System.Drawing.Size(61, 61);
            this.whitePawn6.TabIndex = 4;
            // 
            // whitePawn5
            // 
            this.whitePawn5.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn5.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn5.Location = new System.Drawing.Point(262, 386);
            this.whitePawn5.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn5.Name = "whitePawn5";
            this.whitePawn5.Size = new System.Drawing.Size(61, 61);
            this.whitePawn5.TabIndex = 4;
            // 
            // whitePawn4
            // 
            this.whitePawn4.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn4.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn4.Location = new System.Drawing.Point(201, 386);
            this.whitePawn4.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn4.Name = "whitePawn4";
            this.whitePawn4.Size = new System.Drawing.Size(61, 61);
            this.whitePawn4.TabIndex = 4;
            // 
            // whitePawn3
            // 
            this.whitePawn3.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn3.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn3.Location = new System.Drawing.Point(140, 386);
            this.whitePawn3.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn3.Name = "whitePawn3";
            this.whitePawn3.Size = new System.Drawing.Size(61, 61);
            this.whitePawn3.TabIndex = 4;
            // 
            // whitePawn2
            // 
            this.whitePawn2.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn2.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn2.Location = new System.Drawing.Point(79, 386);
            this.whitePawn2.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn2.Name = "whitePawn2";
            this.whitePawn2.Size = new System.Drawing.Size(61, 61);
            this.whitePawn2.TabIndex = 3;
            // 
            // whitePawn1
            // 
            this.whitePawn1.BackColor = System.Drawing.Color.Transparent;
            this.whitePawn1.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.whitePawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whitePawn1.Controls.Add(this.panel8);
            this.whitePawn1.Location = new System.Drawing.Point(18, 386);
            this.whitePawn1.Margin = new System.Windows.Forms.Padding(0);
            this.whitePawn1.Name = "whitePawn1";
            this.whitePawn1.Size = new System.Drawing.Size(61, 61);
            this.whitePawn1.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(0, 61);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(61, 61);
            this.panel8.TabIndex = 3;
            // 
            // blackRook1
            // 
            this.blackRook1.BackColor = System.Drawing.Color.Transparent;
            this.blackRook1.BackgroundImage = global::ChessApp.Properties.Resources.blackRook;
            this.blackRook1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackRook1.Controls.Add(this.panel7);
            this.blackRook1.Location = new System.Drawing.Point(18, 20);
            this.blackRook1.Margin = new System.Windows.Forms.Padding(0);
            this.blackRook1.Name = "blackRook1";
            this.blackRook1.Size = new System.Drawing.Size(61, 61);
            this.blackRook1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(0, 61);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(61, 61);
            this.panel7.TabIndex = 3;
            // 
            // blackKnight1
            // 
            this.blackKnight1.BackColor = System.Drawing.Color.Transparent;
            this.blackKnight1.BackgroundImage = global::ChessApp.Properties.Resources.blackKinght;
            this.blackKnight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackKnight1.Controls.Add(this.panel14);
            this.blackKnight1.Controls.Add(this.panel12);
            this.blackKnight1.Location = new System.Drawing.Point(79, 20);
            this.blackKnight1.Margin = new System.Windows.Forms.Padding(0);
            this.blackKnight1.Name = "blackKnight1";
            this.blackKnight1.Size = new System.Drawing.Size(61, 61);
            this.blackKnight1.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Location = new System.Drawing.Point(0, 61);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(61, 61);
            this.panel12.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BackgroundImage = global::ChessApp.Properties.Resources.blackPawn;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Location = new System.Drawing.Point(61, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(61, 61);
            this.panel14.TabIndex = 6;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel16.Location = new System.Drawing.Point(0, 61);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(61, 61);
            this.panel16.TabIndex = 3;
            // 
            // blackKnight2
            // 
            this.blackKnight2.BackColor = System.Drawing.Color.Transparent;
            this.blackKnight2.BackgroundImage = global::ChessApp.Properties.Resources.blackKinght;
            this.blackKnight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackKnight2.Controls.Add(this.panel28);
            this.blackKnight2.Location = new System.Drawing.Point(384, 20);
            this.blackKnight2.Margin = new System.Windows.Forms.Padding(0);
            this.blackKnight2.Name = "blackKnight2";
            this.blackKnight2.Size = new System.Drawing.Size(61, 61);
            this.blackKnight2.TabIndex = 6;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel28.Location = new System.Drawing.Point(0, 61);
            this.panel28.Margin = new System.Windows.Forms.Padding(0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(61, 61);
            this.panel28.TabIndex = 3;
            // 
            // blackRook2
            // 
            this.blackRook2.BackColor = System.Drawing.Color.Transparent;
            this.blackRook2.BackgroundImage = global::ChessApp.Properties.Resources.blackRook;
            this.blackRook2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackRook2.Controls.Add(this.panel30);
            this.blackRook2.Location = new System.Drawing.Point(445, 20);
            this.blackRook2.Margin = new System.Windows.Forms.Padding(0);
            this.blackRook2.Name = "blackRook2";
            this.blackRook2.Size = new System.Drawing.Size(61, 61);
            this.blackRook2.TabIndex = 6;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Transparent;
            this.panel30.BackgroundImage = global::ChessApp.Properties.Resources.whitePawn;
            this.panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel30.Location = new System.Drawing.Point(0, 61);
            this.panel30.Margin = new System.Windows.Forms.Padding(0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(61, 61);
            this.panel30.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.boardPanel.ResumeLayout(false);
            this.blackPawn8.ResumeLayout(false);
            this.blackPawn7.ResumeLayout(false);
            this.blackPawn6.ResumeLayout(false);
            this.blackPawn5.ResumeLayout(false);
            this.blackPawn4.ResumeLayout(false);
            this.blackPawn3.ResumeLayout(false);
            this.blackPawn2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.blackPawn1.ResumeLayout(false);
            this.whitePawn1.ResumeLayout(false);
            this.blackRook1.ResumeLayout(false);
            this.blackKnight1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.blackKnight2.ResumeLayout(false);
            this.blackRook2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMoveSheetToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhiteMoves;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackMoves;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Panel whitePawn1;
        private System.Windows.Forms.Panel whitePawn8;
        private System.Windows.Forms.Panel whitePawn7;
        private System.Windows.Forms.Panel whitePawn6;
        private System.Windows.Forms.Panel whitePawn5;
        private System.Windows.Forms.Panel whitePawn4;
        private System.Windows.Forms.Panel whitePawn3;
        private System.Windows.Forms.Panel whitePawn2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel blackPawn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel blackPawn8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel blackPawn7;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel blackPawn6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel blackPawn5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel blackPawn4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel blackPawn3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel blackPawn2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel blackRook2;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel blackKnight2;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel blackKnight1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel blackRook1;
        private System.Windows.Forms.Panel panel7;
    }
}

