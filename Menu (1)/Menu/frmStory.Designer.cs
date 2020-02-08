namespace Menu
{
    partial class frmStory
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStory));
            this.BiggerTxtBx = new System.Windows.Forms.TextBox();
            this.BigBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BiggerTxtBx
            // 
            this.BiggerTxtBx.BackColor = System.Drawing.Color.Gainsboro;
            this.BiggerTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiggerTxtBx.ForeColor = System.Drawing.Color.Green;
            this.BiggerTxtBx.Location = new System.Drawing.Point(69, 26);
            this.BiggerTxtBx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BiggerTxtBx.Multiline = true;
            this.BiggerTxtBx.Name = "BiggerTxtBx";
            this.BiggerTxtBx.ReadOnly = true;
            this.BiggerTxtBx.Size = new System.Drawing.Size(1050, 486);
            this.BiggerTxtBx.TabIndex = 0;
            this.BiggerTxtBx.Text = resources.GetString("BiggerTxtBx.Text");
            // 
            // BigBtn
            // 
            this.BigBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.BigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigBtn.ForeColor = System.Drawing.Color.Purple;
            this.BigBtn.Location = new System.Drawing.Point(69, 540);
            this.BigBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BigBtn.Name = "BigBtn";
            this.BigBtn.Size = new System.Drawing.Size(1052, 100);
            this.BigBtn.TabIndex = 1;
            this.BigBtn.Text = "<play this game to try to catch the mouse>";
            this.BigBtn.UseVisualStyleBackColor = false;
            this.BigBtn.Click += new System.EventHandler(this.BigBtn_Click);
            // 
            // frmStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BigBtn);
            this.Controls.Add(this.BiggerTxtBx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStory";
            this.Text = "Story......  I Think";
            this.Load += new System.EventHandler(this.FrmStory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BiggerTxtBx;
        private System.Windows.Forms.Button BigBtn;
    }
}