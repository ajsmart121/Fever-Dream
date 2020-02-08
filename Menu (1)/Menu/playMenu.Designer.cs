namespace Menu
{
    partial class playMenu
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
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.Purple;
            this.btnMulti.Location = new System.Drawing.Point(130, 113);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(163, 32);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Story Mode";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSingle.FlatAppearance.BorderSize = 0;
            this.btnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingle.ForeColor = System.Drawing.Color.Purple;
            this.btnSingle.Location = new System.Drawing.Point(130, 168);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(163, 32);
            this.btnSingle.TabIndex = 2;
            this.btnSingle.Text = "1 player";
            this.btnSingle.UseVisualStyleBackColor = false;
            this.btnSingle.Click += new System.EventHandler(this.BtnSingle_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Thistle;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Green;
            this.txtName.Location = new System.Drawing.Point(108, 39);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(212, 31);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Fever Dream";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(130, 222);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // playMenu
            // 
            this.AccessibleName = "playMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.btnMulti);
            this.MaximizeBox = false;
            this.Name = "playMenu";
            this.Text = "PlayMenu";
            this.Load += new System.EventHandler(this.PlayMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBack;
    }
}