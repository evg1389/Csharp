namespace Lesson7
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
            this.butGame = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGame
            // 
            this.butGame.Location = new System.Drawing.Point(56, 31);
            this.butGame.Name = "butGame";
            this.butGame.Size = new System.Drawing.Size(69, 25);
            this.butGame.TabIndex = 0;
            this.butGame.Text = "Играть";
            this.butGame.UseVisualStyleBackColor = true;
            this.butGame.Click += new System.EventHandler(this.butGame_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(54, 80);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(70, 26);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 160);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGame;
        private System.Windows.Forms.Button butClose;
    }
}