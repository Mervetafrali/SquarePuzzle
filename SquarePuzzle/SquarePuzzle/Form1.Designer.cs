namespace SquarePuzzle
{
    partial class Puzzle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plybtn = new System.Windows.Forms.Button();
            this.scorebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SquarePuzzle.Properties.Resources.Integration100;
            this.pictureBox1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plybtn
            // 
            this.plybtn.Location = new System.Drawing.Point(49, 274);
            this.plybtn.Name = "plybtn";
            this.plybtn.Size = new System.Drawing.Size(103, 48);
            this.plybtn.TabIndex = 1;
            this.plybtn.Text = "Play";
            this.plybtn.UseCompatibleTextRendering = true;
            this.plybtn.UseVisualStyleBackColor = true;
            this.plybtn.Click += new System.EventHandler(this.plybtn_Click);
            // 
            // scorebtn
            // 
            this.scorebtn.Location = new System.Drawing.Point(696, 274);
            this.scorebtn.Name = "scorebtn";
            this.scorebtn.Size = new System.Drawing.Size(109, 48);
            this.scorebtn.TabIndex = 2;
            this.scorebtn.Text = "Score";
            this.scorebtn.UseVisualStyleBackColor = true;
            this.scorebtn.Click += new System.EventHandler(this.scorebtn_Click);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 535);
            this.Controls.Add(this.scorebtn);
            this.Controls.Add(this.plybtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Puzzle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Puzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button plybtn;
        private System.Windows.Forms.Button scorebtn;
    }
}

