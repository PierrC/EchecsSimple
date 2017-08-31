namespace PopUpTesting
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
            this.popUpButton1 = new System.Windows.Forms.Button();
            this.popUpButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popUpButton1
            // 
            this.popUpButton1.Location = new System.Drawing.Point(92, 48);
            this.popUpButton1.Name = "popUpButton1";
            this.popUpButton1.Size = new System.Drawing.Size(75, 23);
            this.popUpButton1.TabIndex = 0;
            this.popUpButton1.Text = "Pop Up 1";
            this.popUpButton1.UseVisualStyleBackColor = true;
            this.popUpButton1.Click += new System.EventHandler(this.popUpButton1_Click);
            // 
            // popUpButton2
            // 
            this.popUpButton2.Location = new System.Drawing.Point(92, 125);
            this.popUpButton2.Name = "popUpButton2";
            this.popUpButton2.Size = new System.Drawing.Size(75, 23);
            this.popUpButton2.TabIndex = 1;
            this.popUpButton2.Text = "Pop Up 2";
            this.popUpButton2.UseVisualStyleBackColor = true;
            this.popUpButton2.Click += new System.EventHandler(this.popUpButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.popUpButton2);
            this.Controls.Add(this.popUpButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button popUpButton1;
        private System.Windows.Forms.Button popUpButton2;
    }
}

