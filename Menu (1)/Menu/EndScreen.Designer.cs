namespace Menu
{
    partial class EndScreen
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
            this.btnGOBack = new System.Windows.Forms.Button();
            this.txtGOQuit = new System.Windows.Forms.Button();
            this.txtGameOver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGOBack
            // 
            this.btnGOBack.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGOBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGOBack.ForeColor = System.Drawing.Color.Purple;
            this.btnGOBack.Location = new System.Drawing.Point(145, 153);
            this.btnGOBack.Name = "btnGOBack";
            this.btnGOBack.Size = new System.Drawing.Size(132, 36);
            this.btnGOBack.TabIndex = 1;
            this.btnGOBack.Text = "Back to Start";
            this.btnGOBack.UseVisualStyleBackColor = false;
            this.btnGOBack.Click += new System.EventHandler(this.BtnGOBack_Click);
            // 
            // txtGOQuit
            // 
            this.txtGOQuit.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGOQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGOQuit.ForeColor = System.Drawing.Color.Purple;
            this.txtGOQuit.Location = new System.Drawing.Point(145, 218);
            this.txtGOQuit.Name = "txtGOQuit";
            this.txtGOQuit.Size = new System.Drawing.Size(132, 36);
            this.txtGOQuit.TabIndex = 2;
            this.txtGOQuit.Text = "Quit";
            this.txtGOQuit.UseVisualStyleBackColor = false;
            this.txtGOQuit.Click += new System.EventHandler(this.TxtGOQuit_Click);
            // 
            // txtGameOver
            // 
            this.txtGameOver.BackColor = System.Drawing.Color.Thistle;
            this.txtGameOver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameOver.ForeColor = System.Drawing.Color.Green;
            this.txtGameOver.Location = new System.Drawing.Point(83, 61);
            this.txtGameOver.Multiline = true;
            this.txtGameOver.Name = "txtGameOver";
            this.txtGameOver.ReadOnly = true;
            this.txtGameOver.Size = new System.Drawing.Size(257, 44);
            this.txtGameOver.TabIndex = 3;
            this.txtGameOver.Text = "GAME OVER!";
            this.txtGameOver.TextChanged += new System.EventHandler(this.TxtGameOver_TextChanged);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.txtGameOver);
            this.Controls.Add(this.txtGOQuit);
            this.Controls.Add(this.btnGOBack);
            this.MaximizeBox = false;
            this.Name = "EndScreen";
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGOBack;
        private System.Windows.Forms.Button txtGOQuit;
        private System.Windows.Forms.TextBox txtGameOver;
    }
}