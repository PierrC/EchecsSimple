namespace ChessApp3
{
    partial class ChessApp3Form
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
            this.renderAreaControl1 = new ChessApp3.RenderAreaControl();
            this.SuspendLayout();
            // 
            // renderAreaControl1
            // 
            this.renderAreaControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderAreaControl1.Location = new System.Drawing.Point(0, 0);
            this.renderAreaControl1.Name = "renderAreaControl1";
            this.renderAreaControl1.Size = new System.Drawing.Size(418, 417);
            this.renderAreaControl1.TabIndex = 0;
            // 
            // ChessApp3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 418);
            this.Controls.Add(this.renderAreaControl1);
            this.Name = "ChessApp3Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RenderAreaControl renderAreaControl1;
    }
}

